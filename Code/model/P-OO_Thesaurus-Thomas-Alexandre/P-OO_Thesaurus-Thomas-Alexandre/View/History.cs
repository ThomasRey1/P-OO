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
    public partial class History : Form
    {
        private Controler _controller;

        public Controler Controler
        {
            get { return _controller; }
            set { _controller = value; }
        }

        public History()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnIndexingForm_Click(object sender, EventArgs e)
        {
            Controler.ShowIndexing();
        }

        public void GetAndShowHistory(List<Index> index)
        {
            lstBoxFileIndexingDate.Items.Clear();
            lstBoxFileNumber.Items.Clear();
            lstBoxFilePath.Items.Clear();

            foreach (Index item in index)
            {
                lstBoxFileIndexingDate.Items.Add(item.DateIndex);
                lstBoxFileNumber.Items.Add(item.IdIndex);
                lstBoxFilePath.Items.Add(item.PathIndex);
            }

            lblNumberResults.Text = index.Count + " Resultats";
        }

        private void cmbBoxResearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
