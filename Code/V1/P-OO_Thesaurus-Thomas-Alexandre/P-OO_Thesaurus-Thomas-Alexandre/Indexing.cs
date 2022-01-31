using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public partial class indexing : Form
    {
        DriveInfo[] allDrive = DriveInfo.GetDrives();
        public indexing()
        {
            InitializeComponent();
            foreach (DriveInfo drive in allDrive)
            {
                cmbBoxDisk.Items.Add(drive.Name);
            }
            cmbBoxDisk.SelectedIndex = 1;
        }

        private void cmbBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlusFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "+";
        }

        private void btnMinusFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "-";
        }

        private void btnANDFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnORFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "OR";
        }
    }
}
