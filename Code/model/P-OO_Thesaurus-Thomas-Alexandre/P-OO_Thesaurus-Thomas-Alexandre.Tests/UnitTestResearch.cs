using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using P_OO_Thesaurus_Thomas_Alexandre;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace P_OO_Thesaurus_Thomas_Alexandre.Tests
{
    [TestClass]
    public class UnitTestResearch
    {
        [TestMethod]
        public void Search_1_Result()
        {
            // Arrange
            Research search = new Research(@"F:\");
            List<File> AllFiles = new List<File>();
            int Countfile = 0;
            string research = "0";
            string extension = ".*";

            // Act
            DirectoryInfo drive = new DirectoryInfo(@"F:\");
            FileInfo[] fileName = drive.GetFiles("*.*");
            int i = 0;
            foreach (FileInfo file in fileName)
            {
                i++;
                File currentFile = new File();
                currentFile.CurrentFile = file;
                currentFile.GivenIndex = i;
                currentFile.IndexationDate = DateTime.Now;
                AllFiles.Add(currentFile);
            }
            DirectoryInfo[] directoryName = drive.GetDirectories("*.*");
            foreach (DirectoryInfo directories in directoryName)
            {
                i++;
                File currentDirectory = new File();
                currentDirectory.CurrentDirectory = directories;
                currentDirectory.GivenIndex = i;
                currentDirectory.IndexationDate = DateTime.Now;
                AllFiles.Add(currentDirectory);
            }
            search.Search(research, extension, new ListBox(), new ListBox(), new ListBox(), new ListBox());

            foreach (File currentFile in AllFiles)
            {
                if (currentFile.CurrentFile != null)
                {
                    if (extension == ".*" && currentFile.CurrentFile.Name.Contains(research))
                    {
                        Countfile++;
                    }
                    else if (currentFile.CurrentFile.Extension == extension && currentFile.CurrentFile.Name.Contains(research))
                    {
                        Countfile++;
                    }
                }
                else
                {
                    if (extension == ".*" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        Countfile++;
                    }
                    else if (extension == ".Dossier" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        Countfile++;
                    }
                }
            }

            // Assert
            // Assert.méthode(valeur attendu, valeur obtenu, déscription);
            Assert.AreEqual(Countfile, search.CountResult(), "Il devrait avoir 1 dans la liste");
        }
    }
}
