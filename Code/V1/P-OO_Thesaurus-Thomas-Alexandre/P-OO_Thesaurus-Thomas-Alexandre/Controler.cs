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

        private Model _model;

        public Model Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public Indexing View
        {
            get { return _view; }
            set { _view = value; }
        }

        public Controler(Indexing indexing, Model model)
        {
            _view = indexing;
            _model = model;
            _view.Controler = this;
            _model.Controler = this;
        }

    }
}
