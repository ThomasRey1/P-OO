using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_OO_Thesaurus_Thomas_Alexandre;
using System.Windows.Forms;
using System.Collections.Generic;

namespace X_P_OO_Tests_Unitaires_Thomas_Alexandre
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsResearchCountGood()
        {
            //arrange (d�claration des variables)                        
            string path = @"..\Unit test\";
            Indexing indexing = new Indexing();
            ListBox lbFileName = indexing.lstBoxFileName;
            ListBox lbType = indexing.lstBoxFileType;
            ListBox lbSize = indexing.lstBoxFileSize;
            ListBox lbPath = indexing.lstBoxFilePath;            

            //act (code de test)
            Research research = new Research(path);

            //assert (renvoi du r�sultat)
            Assert.AreEqual(/*r�sultat attendu*/3, /*r�sultat actuel*/research.Search("", "*", lbFileName, lbType, lbSize, lbPath).Count, /*string expliquant le r�sultat attendu*/"nombre d'�l�ments dans la liste = 3");
        }

        [TestMethod]
        public void IsResearchFileNameGood()
        {
            //arrange (d�claration des variables)                        
            Indexing indexing = new Indexing();
            string path = @"..\Unit test\";
            ListBox lbFileName = indexing.lstBoxFileName;
            ListBox lbType = indexing.lstBoxFileType;
            ListBox lbSize = indexing.lstBoxFileSize;
            ListBox lbPath = indexing.lstBoxFilePath;
            List<File> result = new List<File>();

            bool namesAreRight = false;
            //act (code de test)
            Research research = new Research(path);
            result = research.Search("", "*", lbFileName, lbType, lbSize, lbPath);

            if (result[0].CurrentFile.Name == "test3.txt" && result[1].CurrentDirectory.Name == "test1" && result[2].CurrentDirectory.Name == "test2")
            {
                namesAreRight = true;
            }
            else
            {
                namesAreRight = false;
            }



            //assert (renvoi du r�sultat)
            Assert.AreEqual(/*r�sultat attendu*/true, /*r�sultat actuel*/namesAreRight, /*string expliquant le r�sultat attendu*/"true = nom des �l�ments de liste juste");
        }

        /// <summary>
        /// verify only text file
        /// </summary>
        [TestMethod]        
        public void IsResearchFileContentGood()
        {
            //arrange (d�claration des variables)                        
            Indexing indexing = new Indexing();
            string path = @"..\Unit test\";
            ListBox lbFileName = indexing.lstBoxFileName;
            ListBox lbType = indexing.lstBoxFileType;
            ListBox lbSize = indexing.lstBoxFileSize;
            ListBox lbPath = indexing.lstBoxFilePath;
            List<File> result = new List<File>();

            bool namesAreRight = false;
            //act (code de test)
            Research research = new Research(path);
            result = research.Search("", "*", lbFileName, lbType, lbSize, lbPath);

            if (result[0].CurrentFile.Name == "test3.txt" && result[1].CurrentDirectory.Name == "test1" && result[2].CurrentDirectory.Name == "test2")
            {
                namesAreRight = true;
            }
            else
            {
                namesAreRight = false;
            }



            //assert (renvoi du r�sultat)
            Assert.AreEqual(/*r�sultat attendu*/true, /*r�sultat actuel*/namesAreRight, /*string expliquant le r�sultat attendu*/"true = nom des �l�ments de liste juste");
        }
    }
}
