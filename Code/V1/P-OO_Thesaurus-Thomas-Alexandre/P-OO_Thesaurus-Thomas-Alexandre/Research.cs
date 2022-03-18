using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public  class Research
    {// Properties
        private string _researchingString;
        private List<File> _filesObtained;

        public List<File> FileObtained
        {
            get { return _filesObtained; }
            set { _filesObtained = value; }
        }        
        private List<File> AllFiles = new List<File>();
        private int _numberResult;

        // Getter - Setter


        /// <summary>
        /// Constructor
        /// </summary>
        public Research(string path)
        {
            DirectoryInfo drive = new DirectoryInfo(path);
            FileInfo[] fileName = drive.GetFiles("*.*");
            int i = 0;
            foreach (FileInfo file in fileName)
            {
                i++;
                File currentFile = new File(file, i);
                currentFile.IndexationDate = DateTime.Now;
                AllFiles.Add(currentFile);
            }
            DirectoryInfo[] directoryName = drive.GetDirectories("*.*");
            foreach (DirectoryInfo directories in directoryName)
            {
                i++;
                File currentDirectory = new File(directories, i);
                currentDirectory.IndexationDate = DateTime.Now;
                AllFiles.Add(currentDirectory);
            }
        }
        
        public void AddFilter(string btnFunction)
        {
            switch (btnFunction)
            {
                case "plus":

                    break;
                case "minus":

                    break;
                case "or":

                    break;
                case "and":

                    break;
                default:
                    break;
            }            
        }

        public List<File> Search(string research, string extension, ListBox lstBoxName, ListBox lstBoxType, ListBox lstBoxSize, ListBox lstBoxPath, string filter = "")
        {
            _filesObtained = new List<File>();
            foreach (File currentFile in AllFiles)
            {
                if (currentFile.CurrentFile == null)
                {
                    if (extension == "*" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (extension == "Dossier" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                }
                else 
                {
                    if (extension == "*" && currentFile.CurrentFile.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (currentFile.CurrentFile.Extension == extension && currentFile.CurrentFile.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                }
                
            }

            ShowResult(lstBoxName, lstBoxType, lstBoxSize, lstBoxPath);
            return _filesObtained;
        }

        private void ShowResult(ListBox lstBoxName, ListBox lstBoxType, ListBox lstBoxSize, ListBox lstBoxPath)
        {
            lstBoxName.Items.Clear();
            lstBoxType.Items.Clear();
            lstBoxSize.Items.Clear();
            lstBoxPath.Items.Clear();
            foreach (File file in _filesObtained)
            {
                if (file.CurrentFile != null)
                {
                    lstBoxName.Items.Add($"{file.CurrentFile.Name}");
                    lstBoxType.Items.Add($"{file.CurrentFile.Extension.ToLower()}");
                    lstBoxSize.Items.Add($"{file.CurrentFile.Length}");
                    lstBoxPath.Items.Add($"{file.CurrentFile.FullName}");
                }
                else
                {
                    lstBoxName.Items.Add($"{file.CurrentDirectory.Name}");
                    lstBoxType.Items.Add("Dossier");
                    lstBoxPath.Items.Add($"{file.CurrentDirectory.FullName}");
                }
            }
        }

        public int CountResult()
        {
            return _filesObtained.Count;
        }
    }
}
