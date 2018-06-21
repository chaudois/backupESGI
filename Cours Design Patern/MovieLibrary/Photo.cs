using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Photo
    {
        byte[] data;
        public Photo(byte[] data)
        {
            this.data = data;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
