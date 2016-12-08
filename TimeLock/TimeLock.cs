using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLock
{
    public partial class TimeLock : Form
    {
        public TimeLock()
        {
            InitializeComponent();
        }

        private void TimeLock_Load(object sender, EventArgs e)
        {
            txtChainSaveLocation.Text = Path.GetDirectoryName(Assembly.GetAssembly(typeof(TimeLock)).Location);
        }

        private HashScheduler _hashScheduler;
        private Stopwatch _stopwatch;


        public void EncryptMessage(string message)
        {
            byte[] bmsg = Encoding.ASCII.GetBytes(message);
            byte[][] chainStart = new byte[_hashScheduler.ThreadCount + 1][];
            for (int i = 0; i < _hashScheduler.ThreadCount; i++)
                chainStart[i] = _hashScheduler.ThreadPool[i].HashChainGenerator.Seed;
            chainStart[chainStart.Length - 1] = bmsg;
            byte[][] chainEnd = new byte[_hashScheduler.ThreadCount ][];
            for (int i = 0; i < _hashScheduler.ThreadCount; i++)
                chainEnd[i] = _hashScheduler.ThreadPool[i].HashChainGenerator.HashBuffer;
            
            byte[][] chainCiphers = new byte[_hashScheduler.ThreadCount][];
            byte[][] chainIVs = new byte[_hashScheduler.ThreadCount][];
            for (int i = 0; i < _hashScheduler.ThreadCount; i++)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = chainEnd[i];
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(chainStart[i + 1], 0, chainStart[i + 1].Length);
                                cs.FlushFinalBlock();
                            }
                            chainCiphers[i] = ms.ToArray();
                            chainIVs[i] = aesAlg.IV;
                        }
                    }
                }
            }

            string o = $"Start: {BitConverter.ToString(chainStart[0]).Replace("-", "")}\n" +
                       $"Chain -\n";
            for (int i = 0; i < chainCiphers.Length; i++)
            {
                o +=
                    $"\tEnc: {BitConverter.ToString(chainCiphers[i]).Replace("-", "")}\tIV: {BitConverter.ToString(chainIVs[i]).Replace("-", "")}\n";
            }
            txtEncryptOutput.Text = txtEncryptOutput.Text + o;

        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            int val = Math.Min((int)(100 * _stopwatch.Elapsed.TotalSeconds / (int)nmbEncryptSeconds.Value), 100);
            progressBarChain.Value = val;
            lblEncryptProgress.Text =
                $"{val}% complete";
        }

        private void TimeLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterruptChain();
        }


        private void btnChainLock_Click(object sender, EventArgs e)
        {
            int threads = (int)nmbEncryptThreads.Value;

            _stopwatch = Stopwatch.StartNew();
            _hashScheduler = new HashScheduler(threads);
            _hashScheduler.Start();
            timerUpdate.Start();

            txtEncryptOutput.Text = "";
            grpChainGenerationOptions.Enabled = false;
            btnChainLock.Enabled = false;
            btnChainInterrupt.Enabled = true;

            Task.Delay((int)nmbEncryptSeconds.Value * 1000).ContinueWith(a =>
            {
                InterruptChain();
            });
        }

        private void btnChainInterrupt_Click(object sender, EventArgs e)
        {
            InterruptChain();
        }

        public void InterruptChain()
        {

            _hashScheduler?.Interrupt();
            timerUpdate.Stop();
            progressBarChain.Value = 100;
            _stopwatch?.Stop();
            
            grpChainGenerationOptions.Enabled = true;
            btnChainInterrupt.Enabled = false;
            btnChainLock.Enabled = true;
            _hashScheduler = null;
        }

        
    }
}
