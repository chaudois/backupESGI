using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderFile;
using NFluent;
using System.Collections.Generic;

namespace DesignPatterns
{
    [TestClass]
    public class FolderFileTest
    {
        [TestMethod]
        public void Should_folder_contains_one_element_when_gettings_contains()
        {
            var textFile = new File { Name = "data.txt" };
            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.Explorables = new List<IElement> { textFile };

            var containsNumber = parentFolder.GetContainsNumber();

            Check.That(containsNumber).IsEqualTo(1);
        }
        [TestMethod]
        public void should_folder_display_content(){
            Folder folder = CreateFolderTree();
            List<string> content = folder.GetFilesNames();
            folder.printFolder();
            foreach (string item in content)
            {
                System.Console.WriteLine(item);
            }

            Check.That(content[1].Contains("textFile.txt"));
        }
        [TestMethod]
        public void Should_folder_contains_three_elements_when_gettings_contains()
        {
            var folder = CreateFolderTree();

            var containsNumber = folder.GetContainsNumber();

            Check.That(containsNumber).IsEqualTo(3);
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File { Name = "textFile.txt" };
            var textFile2 = new File { Name = "textFile2.txt" };
            var firstFolder = new Folder { Name = "firstFolder" };
            var secondFolder = new Folder { Name = "secondFolder" };
            firstFolder.Explorables = new List<IElement> { textFile2 };
            Link lien = new Link { target = textFile, Name = "lien1" };
            secondFolder.Explorables = new List<IElement>{ lien };
            var parentFolder = new Folder { Name = "parentFolder" };

            parentFolder.Explorables = new List<IElement> { firstFolder,secondFolder, textFile };

            return parentFolder;
        }
    }
}
