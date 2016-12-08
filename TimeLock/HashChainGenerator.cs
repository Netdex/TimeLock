using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace TimeLock
{
    class HashChainGenerator : IDisposable
    {
        public long Iteration { get; private set; }
        public byte[] Seed { get; private set; }
        public byte[] HashBuffer { get; private set; }
        private readonly HashAlgorithm _shaProvider;

        public HashChainGenerator(byte[] seed)
        {
            Seed = seed;
            _shaProvider = new SHA256Managed();
            HashBuffer = _shaProvider.ComputeHash(seed);
        }

        public void Next()
        {
            _shaProvider.TransformBlock(HashBuffer, 0, HashBuffer.Length, HashBuffer, 0);
            ++Iteration;
        }

        public void Dispose()
        {
            _shaProvider.Dispose();
        }

        public override string ToString()
        {
            return $"      Seed: {BitConverter.ToString(Seed).Replace("-", "")}\n" +
                   $"HashBuffer: {BitConverter.ToString(HashBuffer).Replace("-", "")}\n" +
                   $" Iteration: {Iteration}\n";
        }
    }
}
