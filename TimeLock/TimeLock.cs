using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private HashScheduler _hashScheduler;
        private Stopwatch _stopwatch;

        private int _timeLen;
        private void btnLock_Click(object sender, EventArgs e)
        {
            string plaintext = txtPlaintext.Text;
            int threads = (int)nmbEncryptThreads.Value;

            _timeLen = (int)nmbEncryptSeconds.Value;
            _stopwatch = Stopwatch.StartNew();
            _hashScheduler = new HashScheduler(threads);
            _hashScheduler.Start();
            timerUpdate.Start();

            txtEncryptOutput.Text = "";
            grpEncryptOptions.Enabled = false;
            btnEncryptLock.Enabled = false;
            btnEncryptInterrupt.Enabled = true;

            Task.Delay(_timeLen * 1000).ContinueWith(a =>
              {
                  Interrupt();
              });
        }

        public void Interrupt()
        {
            _hashScheduler?.Interrupt();
            timerUpdate.Stop();
            txtEncryptOutput.Text = _hashScheduler?.ToString();
            grpEncryptOptions.Enabled = true;
            btnEncryptLock.Enabled = true;
            btnEncryptInterrupt.Enabled = false;
            lblEncryptProgress.Text = "DONE!";
            progressBarEncrypt.Value = 100;

            EncryptMessage();
        }

        public void EncryptMessage(string message)
        {
            byte[] bmsg = Encoding.ASCII.GetBytes(message);
            byte[][] chainStart = new byte[_hashScheduler.ThreadCount + 1][];
            for (int i = 0; i < _hashScheduler.ThreadCount; i++)
                chainStart[i] = _hashScheduler.ThreadPool[i].HashChainGenerator.Seed;
            chainStart[chainStart.Length] = bmsg;
            byte[][] chainEnd = new byte[_hashScheduler.ThreadCount ][];
            for (int i = 0; i < _hashScheduler.ThreadCount; i++)
                chainEnd[i] = _hashScheduler.ThreadPool[i].HashChainGenerator.HashBuffer;
            
            byte[][] chainCiphers = new byte[_hashScheduler.ThreadCount][];
            byte[][] chainIVs = new byte[_hashScheduler.ThreadCount][];
            for (int i = 0; i < _hashScheduler.ThreadCount - 1; i++)
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
                                cs.Write(chainStart[i + 1], 0, bmsg.Length);
                            }
                            chainCiphers[i] = ms.ToArray();
                            chainIVs[i] = aesAlg.IV;
                        }
                    }
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            int val = Math.Min((int)(100 * _stopwatch.Elapsed.TotalSeconds / _timeLen), 100);
            progressBarEncrypt.Value = val;
            lblEncryptProgress.Text = val + "%";
        }

        private void TimeLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Interrupt();
        }

        private void btnEncryptInterrupt_Click(object sender, EventArgs e)
        {
            Interrupt();
        }
    }
}
