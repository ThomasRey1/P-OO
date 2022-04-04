using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public partial class ViewHistory : Form
    {
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }
        public ViewHistory()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnIndexingForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewIndexing form = new ViewIndexing();
            form.StartPosition = FormStartPosition.CenterScreen; 
            form.Show();
        }
        public void GetAndShowHistory(List<Index> index)
        {
            lstBoxFileIndexingDate.Items.Clear();
            lstBoxFileNumber.Items.Clear();
            lstBoxFilePath.Items.Clear();

            foreach (Index item in index)
            {
                lstBoxFileIndexingDate.Items.Add(item._dateIndex);
                lstBoxFileNumber.Items.Add(item._idIndex);
                lstBoxFilePath.Items.Add(item._pathIndex);
            }

            lblNumberResults.Text = index.Count + " Resultats";
        }
    }
}
