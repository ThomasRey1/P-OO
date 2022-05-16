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

namespace classeFile
{
    class File
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

        /// <summary>
        /// Open the selected file
        /// </summary>
        public void OpenFile()
        {

        }
    }
}
