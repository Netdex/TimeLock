using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    [Serializable]
    struct HashChain
    {
        public byte[] Seed { get; set; }
        public byte[] HashBytes { get; set; }
        public long Iterations { get; set; }
    }
}
