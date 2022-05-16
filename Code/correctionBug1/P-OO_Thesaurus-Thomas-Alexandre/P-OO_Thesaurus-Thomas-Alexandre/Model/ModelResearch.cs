using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public  class ModelResearch
    {
        // Properties
        private List<File> _filesObtained;
        private List<File> _allFiles;
        private Controler _controler;
        List<string> files = new List<string>();


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

        // Getter - Setter


        /// <summary>
        /// Constructor
        /// </summary>
        public ModelResearch()
        {
           
        }
        public bool GetPath(string path)
        {
            try
            {
                _allFiles = new List<File>();
                DirectoryInfo drive = new DirectoryInfo(path);
                FileInfo[] fileName = drive.GetFiles("*.*");
                int i = 0;
                foreach (FileInfo file in fileName)
                {
                    i++;
                    File currentFile = new File(file, i);
                    currentFile.IndexationDate = DateTime.Now;
                    _allFiles.Add(currentFile);
                }
                DirectoryInfo[] directoryName = drive.GetDirectories("*.*");
                foreach (DirectoryInfo directories in directoryName)
                {
                    i++;
                    File currentDirectory = new File(directories, i);
                    currentDirectory.IndexationDate = DateTime.Now;
                    _allFiles.Add(currentDirectory);
                }
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return true;
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

        public List<File> SearchWeb(string research, Label lblNumberResult, string filter = "filter")
        {
            _filesObtained = new List<File>();
            if (research != "")
            {
                try
                {
                    var url = research;
                    var web = new HtmlWeb();
                    var doc = web.Load(url);
                    if (doc.DocumentNode.SelectNodes("//a[@href]") != null)
                    {
                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                        {
                            File file = new File(link, "url");
                            _filesObtained.Add(file);
                        }
                    }
                    if (doc.DocumentNode.SelectNodes("//img") != null)
                    {
                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img"))
                        {
                            File file = new File(link, "image");
                            _filesObtained.Add(file);
                        }
                    }
                    lblNumberResult.Text = CountResult();
                    return _filesObtained;
                }
                catch (UriFormatException)
                {
                    lblNumberResult.Text = CountResult();
                    return null;
                }
                catch (System.Net.WebException)
                {
                    lblNumberResult.Text = CountResult();
                    return null;
                }
            }
            else
            {
                lblNumberResult.Text = CountResult();
                return null;
            }
        }

        public List<File> Search(string research, string extension, Label lblNumberResult, string filter = "filter")
        {
            _filesObtained = new List<File>();
            foreach (File currentFile in _allFiles)
            {
                if (currentFile.CurrentFile == null)
                {
                    if (extension == " *" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (extension == " Dossier" && currentFile.CurrentDirectory.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                }
                else 
                {
                    if (extension == " *" && currentFile.CurrentFile.Name.Contains(research))
                    {
                        _filesObtained.Add(currentFile);
                    }
                    else if (extension == " Fichier" && currentFile.CurrentFile.Name.Contains(research))
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

        public string InnerHtmlBalise(HtmlNode node)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(node.InnerHtml);
            if(node.Name == "img")
            {
                var htmlBody = node.Attributes[0].Value;
                string innerText = htmlBody;
                innerText = Regex.Replace(innerText, @"\r", "");
                innerText = Regex.Replace(innerText, @"\n", "");
                innerText = Regex.Replace(innerText, @"\s+", " ");
                innerText = innerText.Trim();

                return innerText;
            }
            else
            {
                var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("/");
                string innerText = htmlBody.InnerText;
                innerText = Regex.Replace(innerText, @"\r", "");
                innerText = Regex.Replace(innerText, @"\n", "");
                innerText = Regex.Replace(innerText, @"\s+", " ");
                innerText = innerText.Trim();

                return innerText;
            }
        }
        public string GetFileInfos(string path)
        {
            string fileInfos = string.Empty;
            if (Path.HasExtension(path))
            {
                fileInfos += Path.GetFileNameWithoutExtension(path) + ";";
                fileInfos += Path.GetExtension(path) + ";";
                fileInfos += Path.GetFullPath(path);
            }
            else
            {
                DirectoryInfo drive = new DirectoryInfo(path);
                FileInfo[] fileName = drive.GetFiles("*.*");
                foreach (FileInfo file in fileName)
                {
                    fileInfos += file.Name + ";";
                    fileInfos += file.Extension + ";";
                    fileInfos += Path.GetFullPath(path);
                }
            }
            return fileInfos;

        }

        public List<string> GetPaths(string folderPath)
        {
            List<string> paths = new List<string>();
            try
            {
                DirectoryInfo drive = new DirectoryInfo(folderPath);
                FileInfo[] fileName = drive.GetFiles("*.*");
                foreach (FileInfo file in fileName)
                {
                    if (file.Extension != null)
                    {
                        paths.Add(folderPath + @"\" + file.Name);
                    }
                }
                foreach (string directory in Directory.GetDirectories(folderPath))
                {
                    paths.Add(directory);
                }
            }
            catch (Exception)
            {
                string specialFile = folderPath + "fichier";
            }


            return paths;
        }

        public List<string> IndexFile(string basePath, List<string> paths)
        {
            Path.GetDirectoryName(basePath);

            if (paths.Count == 0)
            {
                return files;
            }
            else
            {
                foreach (string path in paths)
                {
                    if (Path.HasExtension(path))
                    {
                        files.Add(GetFileInfos(path));
                    }
                    else
                    {
                        IndexFile(path, GetPaths(path));
                    }
                }

                return files;
            }

        }
    }
}
