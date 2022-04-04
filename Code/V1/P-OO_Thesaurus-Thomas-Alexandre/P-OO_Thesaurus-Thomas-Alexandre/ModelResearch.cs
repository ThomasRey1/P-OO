using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public  class ModelResearch
    {// Properties
        private string _researchingString;
        private List<File> _filesObtained;
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }

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
        public ModelResearch()
        {
           
        }
        public void GetPath(string path)
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

        public List<File> Search(string research, string extension, Label lblNumberResult, string filter = "filter")
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

            lblNumberResult.Text = CountResult();
            return _filesObtained;
        }

        public string CountResult()
        {
            int  number = _filesObtained.Count;
            string numberResult = number.ToString();
            if (number <= 1)
            {
                numberResult += " Résultat";
            }
            else 
            {
                numberResult += " Résultats";
            }
            return numberResult;
        }
    }
}
