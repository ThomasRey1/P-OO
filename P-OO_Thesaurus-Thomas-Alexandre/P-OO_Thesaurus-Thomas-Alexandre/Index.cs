///ETML
///Auteur : Alexandre King
///Date :07.03.22
///Description : Class for the index and his attributs 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class Index
    {
        //Id of the inxdexation 
        public int IdIndex { get; set; }
        
        //Date of the indexation
        public string DateIndex { get; set; }

        //Path of the thing(s) that is being indexed
        public string PathIndex { get; set; }

        /// <summary>
        /// Constructor of the index
        /// </summary>
        /// <param name="dateIndex">date of the indexation</param>
        /// <param name="pathIndex">path of the thing(s) that is being indexed</param>
        public Index(string dateIndex, string pathIndex)
        {
            DateIndex = dateIndex;
            PathIndex = pathIndex;
        }
    }
}
