///ETML
///Auteur : Thomas Rey
///Date :07.03.22
///Description :Model for the research (not only in the bar but file in the computer too)
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

        /// <summary>
        /// Get all file and add them in a list (get file for when you change driver or get in a folder, 
        /// only get file and folder at the current path not the ones in the folders.
        /// </summary>
        /// <param name="path">current path</param>
        /// <returns>true -> user have acces to the path, false -> user doesn't have access</returns>
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

        /// <summary>
        /// Add filter to the research
        /// </summary>
        /// <param name="btnFunction">function of the button</param>
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

        /// <summary>
        /// search for the web 
        /// </summary>
        /// <param name="research">content of the research bar</param>
        /// <param name="lblNumberResult">label for the number of results</param>
        /// <param name="filter">optionnal parameter if there is a filter from the filter button</param>
        /// <returns>list of file obtained from the web</returns>
        public List<File> SearchWeb(string research, Label lblNumberResult, string filter = "filter")
        {
            _filesObtained = new List<File>();
            // If there is a path in the research bar
            if (research != "")
            {
                try
                {
                    var url = research;
                    var web = new HtmlWeb();
                    var doc = web.Load(url);
                    // Collect all the href in an a balise
                    if (doc.DocumentNode.SelectNodes("//a[@href]") != null)
                    {
                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                        {
                            File file = new File(link, "url");
                            _filesObtained.Add(file);
                        }
                    }
                    // Collect all image
                    if (doc.DocumentNode.SelectNodes("//img") != null)
                    {
                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img"))
                        {
                            File file = new File(link, "image");
                            _filesObtained.Add(file);
                        }
                    }
                    // Count the number
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

        /// <summary>
        /// search in files
        /// </summary>
        /// <param name="research">content of the research bar</param>
        /// <param name="extension">extension from the list of extension</param>
        /// <param name="lblNumberResult">label for the number of results</param>
        /// <param name="filter">optionnal parameter from the filter button</param>
        /// <returns></returns>
        public List<File> Search(string research, string extension, Label lblNumberResult, string filter = "filter")
        {
            _filesObtained = new List<File>();
            //treat the file and folder
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
            //count the results
            lblNumberResult.Text = CountResult();
            return _filesObtained;
        }

        /// <summary>
        /// count the number of results
        /// </summary>
        /// <returns>number of results</returns>
        public string CountResult()
        {
            int  number = _filesObtained.Count;
            string numberResult = number.ToString();
            //if less than 1 result
            if (number <= 1)
            {
                numberResult += " Résultat";
            }
            //if more than 1 result
            else 
            {
                numberResult += " Résultats";
            }
            return numberResult;
        }

        /// <summary>
        /// reformats the names and links displayed in the listboxes
        /// </summary>
        /// <param name="node">determines if it's an image or an href</param>
        /// <returns></returns>
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

        /// <summary>
        /// get all infos of a specific file
        /// </summary>
        /// <param name="path">path to the file</param>
        /// <returns>all the infos of the file (name, extension, full path)</returns>
        public string GetFileInfos(string path)
        {

            string fileInfos = string.Empty;
            //check if file has extension
            if (Path.HasExtension(path))
            {
                fileInfos += Path.GetFileNameWithoutExtension(path) + ";";
                fileInfos += Path.GetExtension(path) + ";";
                fileInfos += Path.GetFullPath(path);
            }
            //else it's a folder (souldn't pass here but in case it does)
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

        /// <summary>
        /// get all the paths in a folder
        /// </summary>
        /// <param name="folderPath">the path of the folder</param>
        /// <returns>list of paths </returns>
        public List<string> GetPaths(string folderPath)
        {
            List<string> paths = new List<string>();
            //try to get all the get all paths catch when it's a file that have the "fichier" extension
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

        /// <summary>
        /// recursive indexing algorithm
        /// </summary>
        /// <param name="basePath">path when the indexing button was pressed</param>
        /// <param name="paths">list of paths of the file or folder</param>
        /// <returns></returns>
        public List<string> IndexFile(string basePath, List<string> paths)
        {
            Path.GetDirectoryName(basePath);
            //if there's no file in folder the algorithm if finished or
            //the algorithme got  in a folder and got all files recursively
            if (paths.Count == 0)
            {
                return files;
            }
            else
            {
                //foreach path in the all the paths
                foreach (string path in paths)
                {
                    //if path has an extension (then it's a file)
                    if (Path.HasExtension(path))
                    {
                        //add the file to the list
                        files.Add(GetFileInfos(path));
                    }
                    //else it's a folder or a file with the "fichier" extension
                    else
                    {
                        //repeat this algorithm with all the paths of the folder
                        IndexFile(path, GetPaths(path));
                    }
                }

                return files;
            }

        }
    }
}
