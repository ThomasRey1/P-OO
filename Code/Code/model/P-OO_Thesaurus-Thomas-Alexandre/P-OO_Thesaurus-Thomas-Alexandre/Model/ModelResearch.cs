using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class ModelResearch
    {// Properties
        private string _researchingString;
        private List<File> _filesObtained = new List<File>();
        private List<File> AllFiles = new List<File>();
        private int _numberResult;
        private Controler _controller;


        // Getter - Setter
        public Controler Controler
        {
            get { return _controller; }
            set { _controller = value; }
        }

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
        }

        public List<File> Search(string research, string extension)
        {
            _filesObtained = new List<File>();
            foreach (File currentFile in AllFiles)
            {
                if (currentFile.CurrentFile != null)
                {
                    if (extension == ".*" && currentFile.CurrentFile.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (currentFile.CurrentFile.Extension == extension && currentFile.CurrentFile.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                }
                else
                {
                    if (extension == ".*" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (extension == ".Dossier" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                }
            }

            return _filesObtained;
        }

        public int CountResult()
        {
            return _filesObtained.Count;
        }
    }
}
