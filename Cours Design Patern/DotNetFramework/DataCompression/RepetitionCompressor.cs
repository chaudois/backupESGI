using Microsoft.Analytics.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataCompression
{
    class RepetitionCompressor : ICompressor
    {
        public string Compress(string data)
        {
            return data + "RepetitionCompressor";
        }
    }
}