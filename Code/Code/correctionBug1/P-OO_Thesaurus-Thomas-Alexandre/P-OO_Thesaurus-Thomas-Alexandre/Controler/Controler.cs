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

            _view.Start();
        }

        public void ShowHistory()
        {
            _viewHistory.Location = _view.Location;
            _viewHistory.GetAndShowHistory();
            _view.Hide();
            _viewHistory.Show();
        }

        public void ShowIndexing()
        {
            _viewHistory.Hide();
            _view.Show();
        }

        public bool GetPath(string path)
        {
            return ModelResearch.GetPath(path);
        }

        public List<File> Search(string research, string extension, Label lblNbResult)
        {
            return ModelResearch.Search(research, extension, lblNbResult);
        }

        public void UpdateIndexingHistory(Index index, string basePath, List<string> filesPaths)
        {            
            ModelIndexing.UpdateIndexingHistory(index, ModelResearch.IndexFile(basePath, filesPaths));
        }

        public List<Index> GetAndShowHistory()
        {
            return ModelIndexing.GetAndShowHistory();
        }
    }
}
