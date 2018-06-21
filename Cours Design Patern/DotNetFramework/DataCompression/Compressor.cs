using System;

namespace DataCompression
{
    public class Compressor  
    {
        private ICompressor compressionType;

        public Compressor(ICompressor type)
        {
            this.compressionType = type;
        }

        public string Compress(string data, ICompressor type)
        {
            return type.Compress(data);
        }
 
    }
}
