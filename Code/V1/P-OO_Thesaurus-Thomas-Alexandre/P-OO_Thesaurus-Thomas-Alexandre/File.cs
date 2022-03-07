using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    class File
    {
        public FileInfo CurrentFile { get; set; }
        public int GivenIndex { get; set; }
        public DateTime IndexationDate { get; set; }
        public DirectoryInfo CurrentDirectory { get; set; }
        public File()
        {

        }
        public void OpenFile(string fileName, string filePath)
        {
            
        }
    }
}
