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
        
        bool _ShowFile = false;         //to know if were looking at the file or the index
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
            if (!_ShowFile)
            {
                Controler.ViewHistory.Hide();
                Controler.View.Show();
            }
            else
            {
                ChangeLabelHistoryForIndex();
                GetAndShowHistory();
                _ShowFile = false;
            }
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

        private void lstBoxFilePath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //index of selected file or folder
            int index = this.lstBoxFilePath.IndexFromPoint(e.Location);
            //if index isn't out of range
            if (index != ListBox.NoMatches)
            {
                if (_ShowFile == false)
                {
                    ChangeLabelHistoryForFile();
                    lstBoxFilePath.Items.Clear();
                    lstBoxFileNumber.Items.Clear();
                    lstBoxFileIndexingDate.Items.Clear();
                    _ShowFile = true;

                    //get the list list of all index in DB
                    List<string> files = Controler.GetAndShowHistoryForFile(index+1);

                    //clear all listbox
                    lstBoxFileIndexingDate.Items.Clear();
                    lstBoxFileNumber.Items.Clear();
                    lstBoxFilePath.Items.Clear();
                    //show each index of the history
                    for (int i = 0; i < files.Count(); i++)
                    {
                        string[] file = files[i].Split(";");
                        lstBoxFileIndexingDate.Items.Add(file[2]);
                        lstBoxFileNumber.Items.Add(file[1]);
                        lstBoxFilePath.Items.Add(file[0]);
                    }

                    //show the number of result
                    lblNumberResults.Text = files.Count + " Resultats";
                }

            }
        }
        /// <summary>
        /// Change the labels of the header for when it's the files that's being show
        /// </summary>
        private void ChangeLabelHistoryForFile()
        {
            lblFileName.Text = "Type";
            lblFilePath.Text = "Nom du fichier";
            lblIndexingDate.Text = "Chemin d'accès";
        }
        /// <summary>
        /// Change the labels of the header for when it's the index that's being show
        /// </summary>
        private void ChangeLabelHistoryForIndex()
        {
            lblFileName.Text = "N°";
            lblFilePath.Text = "Chemin d'accès";
            lblIndexingDate.Text = "Date d'Indexation";
        }
    }
}
