using System.Collections.Generic;

namespace FolderFile
{
    public class Folder :IElement
    {
        public string Name { get; set; }

        public void accept(IWriter writer)
        {
            writer.Write(this);
        }
        public List<IElement> Explorables = new List<IElement>();
        public List<Link> Links = new List<Link>();
        public int GetContainsNumber()
        {
            int filesCount = 0;
            if(Explorables != null)
            {
                filesCount = Explorables.Count;
            }

            

            return filesCount  ;
        }

        public List<string> GetFilesNames(int deepness = 0)
        {
            List<string> retour = new List<string>();

            string espace = "";

            for (int i = 0; i < deepness; i++)
            {
                espace += "  ";
            }
            retour.Add(espace + Name);


            if (Explorables != null && Explorables.Count > 0)
            {
                for (int i = 0; i < Explorables.Count; i++)
                {
                    retour.AddRange(Explorables[i].GetFilesNames(deepness + 1));
                }
            }
            return retour;

        }


        public void printFolder()
        {
            foreach (var item in GetFilesNames())
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
