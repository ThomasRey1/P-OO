using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class Controler
    {
        private Indexing _view;

        private ModelIndexingHistory _model;

        public ModelIndexingHistory Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public Indexing View
        {
            get { return _view; }
            set { _view = value; }
        }

        public Controler(Indexing indexing, ModelIndexingHistory model)
        {
            _view = indexing;
            _model = model;
            _view.Controler = this;
            _model.Controler = this;
        }

        public void UpdateIndexingHistory(Index index)
        {
            Model.UpdateIndexingHistory(index);
        }

        public List<Index> GetAndShowHistory()
        {
            return Model.GetAndShowHistory();
        }
    }
}
