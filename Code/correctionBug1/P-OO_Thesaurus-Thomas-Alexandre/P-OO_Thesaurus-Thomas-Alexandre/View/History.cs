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
    }
}
