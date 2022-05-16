/*
 * Thomas Rey
 * ETML
 * 07.03.22
 * Class for stocked file or directory
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using HtmlAgilityPack;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class File
    {
        // Getter - Setter
        /// <summary>
        /// Data of the file
        /// </summary>
        public FileInfo CurrentFile { get; set; }
        /// <summary>
        /// Indexation
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Date of the indexation
        /// </summary>
        public DateTime IndexationDate { get; set; }
        /// <summary>
        /// Data of the directory
        /// </summary>
        public DirectoryInfo CurrentDirectory { get; set; }
        /// <summary>
        /// Data of the site
        /// </summary>
        public HtmlNode CurrentNode { get; set; }
        /// <summary>
        /// Type of data of the site
        /// </summary>
        public string TypeNode { get; set; }

        /// <summary>
        /// Constructor for file
        /// </summary>
        /// <param name="currentFile">Data of the file</param>
        /// <param name="index">Indexation of the directory</param>
        public File(FileInfo currentFile, int index)
        {
            CurrentFile = currentFile;
            Index = index;
            IndexationDate = DateTime.Now;
        }

        /// <summary>
        /// Contstructor for directory
        /// </summary>
        /// <param name="currentDirectory">Data of the directory</param>
        /// <param name="index">Indexation of the directory</param>
        public File(DirectoryInfo currentDirectory, int index)
        {
            CurrentDirectory = currentDirectory;
            Index = index;
            IndexationDate = DateTime.Now;
        }

        
        public File(HtmlNode currentNode, string typeNode)
        {
            CurrentNode = currentNode;
            TypeNode = typeNode;
            IndexationDate = DateTime.Now;
        }

        /// <summary>
        /// Open the selected file
        /// </summary>
        static public void OpenFile(string fileName)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileName,
            };
            process.Start();
        }
        static public void OpenUrl(string url, string urlBase)
        {
            if (url.StartsWith('/'))
            {
                string[] urlPart = urlBase.Split('/');
                urlPart[urlPart.Length - 1] = url;
                string finalUrl = "";
                for (int i = 0; i < 3; i++)
                {
                    if (urlPart[i] == "http:" || urlPart[i] == "https:")
                    {
                        finalUrl += urlPart[i];
                    }
                    else
                    {
                        finalUrl += "/" + urlPart[i];
                    }
                }
                finalUrl += url;
                Process.Start(new ProcessStartInfo
                {
                    FileName = finalUrl,
                    UseShellExecute = true
                });
            }
            else if (url.Contains("https://") || url.Contains("httpl://"))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else if (url.StartsWith('#'))
            {
                string finalUrl = urlBase + url;
                Process.Start(new ProcessStartInfo
                {
                    FileName = finalUrl,
                    UseShellExecute = true
                });
            }
            else
            {
                string[] urlPart = urlBase.Split('/');
                urlPart[urlPart.Length - 1] = url;
                string finalUrl = "";
                foreach (string item in urlPart)
                {
                    if(item == "http:" || item == "https:")
                    {
                        finalUrl += item;
                    }
                    else
                    {
                        finalUrl += "/" + item;
                    }
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = finalUrl,
                    UseShellExecute = true
                });
            }
        }
    }
}
