using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFile
{
    public interface IElement
    {
        string Name { get; set; }
        
        List<string> GetFilesNames(int deepness = 0);
        void accept(IWriter writer);
    }
}
