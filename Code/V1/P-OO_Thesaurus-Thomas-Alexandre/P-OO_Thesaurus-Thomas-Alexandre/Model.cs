using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class Model
    {
        private Controler _controller;

        public Controler Controler
        {
            get { return _controller; }
            set { _controller = value; }
        }
    }
}
