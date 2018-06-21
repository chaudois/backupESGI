using System.Collections.Generic;

namespace FolderFile
{
    public class File:IElement
    {
        public string Name { get; set; }

        public void accept(IWriter writer)
        {
            writer.Write(this);
        }

        public List<string> GetFilesNames(int deepness = 0)
        {
            string espace = "";
            for (int i = 0; i < deepness; i++)
            {
                espace += "  ";
            }
            return new List<string> { espace+ Name };
        }
    }
}
