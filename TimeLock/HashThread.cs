using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeLock
{
    class HashThread
    {
        public HashChainGenerator HashChainGenerator { get; private set; }
        public int Limit { get; private set; } = int.MaxValue;

        private Thread _backingThread;
        private bool _interrupted = false;

        public HashThread(byte[] seed)
        {
            HashChainGenerator = new HashChainGenerator(seed);
        }

        public HashThread(byte[] seed, int limit) : this(seed)
        {
            Limit = limit;
        }

        public void BeginExecution()
        {
            _backingThread = new Thread(Execute);
            _backingThread.Start();
        }

        public void Interrupt()
        {
            _interrupted = true;
        }

        private void Execute()
        {
            while (!_interrupted && HashChainGenerator.Iteration < Limit)
            {
                HashChainGenerator.Next();
            }
        }

        public override string ToString()
        {
            return HashChainGenerator.ToString();
        }
    }
}
