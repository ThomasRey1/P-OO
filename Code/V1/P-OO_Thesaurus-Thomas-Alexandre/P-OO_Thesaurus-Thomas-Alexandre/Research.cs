/*
 * Thomas Rey
 * 07.02.22
 * ETML
 * Research File
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    class Research
    {
        // Properties
        private string _researchingString;
        private List<File> _filesObtained;
        public List<File> AllFiles { get; set; }
        private int _numberResult;

        // Getter - Setter


        /// <summary>
        /// Constructor
        /// </summary>
        public Research()
        {

            DriveInfo drive = new DriveInfo(@"C:\");
            DirectoryInfo directory = drive.RootDirectory;
            FileInfo[] fileName = directory.GetFiles("*.*");
            foreach (FileInfo file in fileName)
            {
                File currentFile = new File();
                currentFile.CurrentFile = file;
                AllFiles.Add(currentFile);
            }
        }

        public string AddFilter(string btnFunction)
        {
            return "";
        }

        public List<File> Search(string research)
        {
            foreach (File currentFile in AllFiles)
            {
                if(research == currentFile.CurrentFile.Name)
                {
                    _filesObtained.Add(currentFile);
                }
            }
            ShowResult();
            return _filesObtained;
        }

        private void ShowResult()
        {

        }

        public int CountResult()
        {
            return 0;
        }

        public string ChangeExtFileInBar(string extension)
        {
            return "";
        }

        public List<File> ChangeExtFile(string extendion)
        {
            return _filesObtained;
        }
    }
}
