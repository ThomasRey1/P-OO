using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace test
{
    class Research
    {// Properties
        private string _researchingString;
        private List<File> _filesObtained = new List<File>();
        private List<File> AllFiles = new List<File>();
        private int _numberResult;

        // Getter - Setter


        /// <summary>
        /// Constructor
        /// </summary>
        public Research()
        {
            DriveInfo drive = new DriveInfo(@"F:\");
            DirectoryInfo directory = drive.RootDirectory;
            FileInfo[] fileName = directory.GetFiles("*.*");
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
        }

        public string AddFilter(string btnFunction)
        {
            return "";
        }

        public List<File> Search(string research, string extension, ListBox panel)
        {
            _filesObtained = new List<File>();
            foreach (File currentFile in AllFiles)
            {
                if(extension == "" && currentFile.CurrentFile.Name.Contains(research))
                {
                    _filesObtained.Add(currentFile);
                }
                else if (currentFile.CurrentFile.Extension == extension && currentFile.CurrentFile.Name.Contains(research))
                {
                    _filesObtained.Add(currentFile);
                }
            }
            ShowResult(panel);
            return _filesObtained;
        }

        private void ShowResult(ListBox panel)
        {
            panel.Items.Clear();
            foreach(File file in _filesObtained)
            {
                panel.Items.Add($"{file.CurrentFile.Name}       {file.CurrentFile.FullName}       {file.CurrentFile.Extension}");
            }
        }

        public int CountResult()
        {
            return _filesObtained.Count;
        }
    }
}
