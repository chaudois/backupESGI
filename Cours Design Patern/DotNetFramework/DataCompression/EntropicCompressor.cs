using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompression
{
    class EntropicCompressor : ICompressor
    {
        public string Compress(string data)
        {
            return data + "EntropicCompressor";
        }
    }
}
