using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFile
{
    public class Link  : IElement
    {
        public void accept(IWriter writer)
        {
            writer.Write(this);
        }
        public string Name { get ; set ; }
        public IElement target { get; set; }

        public List<string> GetFilesNames(int deepness = 0)
        {
            string space = "";
            for (int i = 0; i < deepness; i++)
            {
                space += "  ";
            }
            return new List<string> {space+ Name };
        }
    }
}
