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
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
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
            Controler.ViewHistory.Hide();
            Controler.View.Show();
        }
        public void GetAndShowHistory()
        {
            List<Index> index = Controler.GetAndShowHistory();

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
            //ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults));
        }
        /*private void ShowResult(List<File> filesObtained)
        {
            lstBoxFileName.Items.Clear();
            lstBoxFileType.Items.Clear();
            lstBoxFileSize.Items.Clear();
            lstBoxFilePath.Items.Clear();
            foreach (File file in filesObtained)
            {
                if (file.CurrentFile != null)
                {
                    lstBoxFileName.Items.Add($"{file.CurrentFile.Name}");
                    lstBoxFileType.Items.Add($"{file.CurrentFile.Extension}");
                    lstBoxFileSize.Items.Add($"{file.CurrentFile.Length}");
                    lstBoxFilePath.Items.Add($"{file.CurrentFile.FullName}");

                    if (!cmbBoxExtensions.Items.Contains(file.CurrentFile.Extension))
                    {
                        if (file.CurrentFile.Extension == "")
                        {
                            lstBoxFileType.Items[lstBoxFileType.Items.Count - 1] = "Fichier";
                            if (!cmbBoxExtensions.Items.Contains(" Fichier"))
                            {
                                cmbBoxExtensions.Items.Add(" Fichier");
                            }
                        }
                        else
                        {
                            cmbBoxExtensions.Items.Add(file.CurrentFile.Extension);
                        }
                    }
                }
                else
                {
                    lstBoxFileName.Items.Add($"{file.CurrentDirectory.Name}");
                    lstBoxFileType.Items.Add($"Dossier");
                    lstBoxFilePath.Items.Add($"{file.CurrentDirectory.FullName}");
                }
            }
        }*/
    }
}
