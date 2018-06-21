using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFile
{
    class Writer : IWriter
    {
        public void Write(IElement element)
        {
            element.accept(this);
        }

        public void Write(Folder element)
        {
            Console.WriteLine(element.Name);
        }

        public void Write(Link element)
        {
            Console.WriteLine(element.Name);
        }

        public void Write(File element)
        {
            Console.WriteLine(element.Name);
        }
    }
}
