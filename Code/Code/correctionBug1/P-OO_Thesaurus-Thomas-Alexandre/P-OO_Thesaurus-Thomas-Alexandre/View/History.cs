///ETML
///Auteur : Alexandre King
///Date :07.03.22
///Description :history view
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
        //define the controler of this view
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }
        /// <summary>
        /// constructor
        /// </summary>
        public History()
        {
            InitializeComponent();
            EventHandler handler = (s, e) =>
            {
                if (s == lstBoxFilePath)
                {
                    lstBoxFileNumber.TopIndex = lstBoxFilePath.TopIndex;
                    lstBoxFileIndexingDate.TopIndex = lstBoxFilePath.TopIndex;
                }
            };

            this.lstBoxFilePath.MouseCaptureChanged += handler;
            this.lstBoxFilePath.MouseHover += handler;
            this.lstBoxFilePath.MouseLeave += handler;
        }

        /// <summary>
        /// Exit the application when the history form is closed
        /// </summary>        
        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //return to the indexing view
        private void btnReturnIndexingForm_Click(object sender, EventArgs e)
        {
            Controler.ViewHistory.Hide();
            Controler.View.Show();
        }
        /// <summary>
        /// show the history
        /// </summary>
        public void GetAndShowHistory()
        {
            //get the list list of all index in DB
            List<Index> index = Controler.GetAndShowHistory();

            //clear all listbox
            lstBoxFileIndexingDate.Items.Clear();
            lstBoxFileNumber.Items.Clear();
            lstBoxFilePath.Items.Clear();
            //show each index of the history
            foreach (Index item in index)
            {
                lstBoxFileIndexingDate.Items.Add(item.DateIndex);
                lstBoxFileNumber.Items.Add(item.IdIndex);
                lstBoxFilePath.Items.Add(item.PathIndex);
            }
            //show the number of result
            lblNumberResults.Text = index.Count + " Resultats";
        }
    }
}
