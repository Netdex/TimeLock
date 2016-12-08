using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    class HashScheduler
    {
        private const int SeedSize = 32;

        public int ThreadCount { get; private set; }

        public HashThread[] ThreadPool { get; private set; };
        private Random _random;

        public HashScheduler(int threadCount)
        {
            ThreadCount = threadCount;

            ThreadPool = new HashThread[ThreadCount];
            _random = new Random();

            for (int i = 0; i < ThreadCount; i++)
            {
                byte[] seed = new byte[SeedSize];
                _random.NextBytes(seed);
                ThreadPool[i] = new HashThread(seed);
            }
        }

        public void Start()
        {
            foreach (var ht in ThreadPool)
            {
                ht.BeginExecution();
            }
        }

        public void Interrupt()
        {
            foreach(var ht in ThreadPool)
            {
                ht.Interrupt();
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (var ht in ThreadPool)
                s += ht.ToString() + "\n";
            return s;
        }
    }
}
