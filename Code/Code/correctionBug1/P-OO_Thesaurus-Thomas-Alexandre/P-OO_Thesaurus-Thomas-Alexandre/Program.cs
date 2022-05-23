///ETML
///Auteur : Alexandre King
///Date :07.03.22
///Description :Is called when the program is started
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Using the MVC template            
            ModelIndexingHistory modelIndexing = new ModelIndexingHistory();
            ModelResearch modelResearch = new ModelResearch();
            Indexing view = new Indexing();
            History history = new History();
            Controler controler = new Controler(history, view, modelIndexing, modelResearch);

            Application.Run(view);
        }
    }
}
