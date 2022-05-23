///ETML
///Auteur : Alexandre King
///Date :07.03.22
///Description :
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class Controler
    {
        //define all the views and model
        private Indexing _view;

        private History _viewHistory;

        private ModelIndexingHistory _modelIndexing;

        private ModelResearch _modelResearch;

        public ModelResearch ModelResearch
        {
            get { return _modelResearch; }
            set { _modelResearch = value; }
        }


        public History ViewHistory
        {
            get { return _viewHistory; }
            set { _viewHistory = value; }
        }


        public ModelIndexingHistory ModelIndexing
        {
            get { return _modelIndexing; }
            set { _modelIndexing = value; }
        }


        public Indexing View
        {
            get { return _view; }
            set { _view = value; }
        }

        /// <summary>
        /// Constructor of the controler
        /// </summary>
        /// <param name="history">view of the history</param>
        /// <param name="indexing">view of the indexing</param>
        /// <param name="modelIndexing">Model for indexing</param>
        /// <param name="modelResearch">Model for research</param>
        public Controler(History history, Indexing indexing, ModelIndexingHistory modelIndexing, ModelResearch modelResearch)
        {
            _viewHistory = history;
            _view = indexing;
            _modelIndexing = modelIndexing;
            _modelResearch = modelResearch;
            _viewHistory.Controler = this;
            _view.Controler = this;
            _modelIndexing.Controler = this;
            _modelResearch.Controler = this;
            //start the program
            _view.Start();
        }

        /// <summary>
        /// show history view and hide indexing view
        /// </summary>
        public void ShowHistory()
        {
            _viewHistory.Location = _view.Location;
            _viewHistory.GetAndShowHistory();
            _view.Hide();
            _viewHistory.Show();
        }

        /// <summary>
        /// show indexing view and hide history view
        /// </summary>
        public void ShowIndexing()
        {
            _viewHistory.Hide();
            _view.Show();
        }

        /// <summary>
        /// get the current path
        /// </summary>
        /// <param name="path">get path</param>
        /// <param name="disk">get the driver</param>
        /// <returns>true if not a web or false if it is</returns>
        public bool GetPath(string path, string disk)
        {
            //if not "site web"
            if(disk != "Site Web")
            {
                //research the path
                return ModelResearch.GetPath(path);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// research all files
        /// </summary>
        /// <param name="research">content of research bar</param>
        /// <param name="extension">content of extension filter</param>
        /// <param name="lblNbResult">label for the number of result</param>
        /// <param name="disk">current driver</param>
        /// <returns>list of files and their infos</returns>
        public List<File> Search(string research, string extension, Label lblNbResult, string disk)
        {
            if (disk != "Site Web")
            {
                return ModelResearch.Search(research, extension, lblNbResult);
            }
            else
            {
                return ModelResearch.SearchWeb(research, lblNbResult);
            }
        }

        /// <summary>
        /// Update the History
        /// </summary>
        /// <param name="index">current index</param>
        /// <param name="basePath">path of the indexing</param>
        /// <param name="filesPaths">list of the files path</param>
        public void UpdateIndexingHistory(Index index, string basePath, List<string> filesPaths)
        {
            ModelIndexing.UpdateIndexingHistory(index, ModelResearch.IndexFile(basePath, filesPaths));
        }
        /// <summary>
        /// get the history for the index
        /// </summary>
        /// <returns>return the history of index</returns>
        public List<Index> GetAndShowHistory()
        {
            return ModelIndexing.GetAndShowHistory();
        }
        /// <summary>
        /// Get the history of the file
        /// </summary>
        /// <returns>history of files</returns>
        public List<string> GetAndShowHistoryForFile(int idIndex)
        {
            return ModelIndexing.GetAndShowHistoryForFile(idIndex);
        }


        /// <summary>
        /// search the html tag in web
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string InnerHtmlBalise(File file)
        {
            return ModelResearch.InnerHtmlBalise(file.CurrentNode);
        }
    }
}
