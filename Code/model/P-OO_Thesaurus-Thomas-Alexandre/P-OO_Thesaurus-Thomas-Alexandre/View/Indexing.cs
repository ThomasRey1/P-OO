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
using System.Diagnostics;
using System.Data.SqlClient;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    
    public partial class Indexing : Form
    {
        private Controler _controller;
            
        public Controler Controler
        {
            get { return _controller; }
            set { _controller = value; }
        }


        bool changeDisk = false;
        int itemClicked = 0;
        DriveInfo[] allDrive = DriveInfo.GetDrives();
        public Indexing()
        {
            InitializeComponent();
            foreach (DriveInfo drive in allDrive)
            {
                cmbBoxDisk.Items.Add(drive.Name);
            }
            lblPathFiles.Text = cmbBoxDisk.Text;
            cmbBoxExtensions.SelectedIndex = 0;
        }

        public void Start()
        {
            cmbBoxDisk.SelectedIndex = 3;
            Controler.GetPath(lblPathFiles.Text);
            ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text));
        }

        private void cmbBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changeDisk == false)
            {
                lblPathFiles.Text = cmbBoxDisk.Text;
                Controler.GetPath(lblPathFiles.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text));

            }
        }

        private void btnPlusFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "<";
        }

        private void btnMinusFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += ">";
        }

        private void btnANDFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "?";
        }

        private void btnORFilter_Click(object sender, EventArgs e)
        {
            cmbBoxResearch.Text += "|";
        }

        private void picBoxDiskNext_Click(object sender, EventArgs e)
        {
            changeDisk = false;
            if (cmbBoxDisk.SelectedIndex != allDrive.Count()-1)
            {
                cmbBoxDisk.SelectedIndex += 1;
            }
        }

        private void picBoxDiskBefore_Click(object sender, EventArgs e)
        {
            changeDisk = false;
            if (cmbBoxDisk.SelectedIndex !=0)
            {
                cmbBoxDisk.SelectedIndex -= 1;
            }
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = lblPathFiles.Text;
            fbd.Description = "--Veuillez séléctionner un dossier à indexer--";
            fbd.ShowNewFolderButton = false;
            fbd.AutoUpgradeEnabled = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                changeDisk = true;
                lblPathFiles.Text = fbd.SelectedPath;
                cmbBoxDisk.SelectedItem = (fbd.SelectedPath).Substring(0, 3);
                Controler.GetPath(lblPathFiles.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text));
                changeDisk = false;
            }            
            {/* 
            ////////Make the filter with all existing extension
            string allFilter = "All Files (*.*)|*.*";
            for (int i = 0; i < cmbBoxExtensions.Items.Count; i++)
            {
                string currentFilter = cmbBoxExtensions.GetItemText(cmbBoxExtensions.Items[i]);
                allFilter += "|" + currentFilter.Substring(1) + " Files (*" + currentFilter + ")|*" + currentFilter;
            }
            /////////open a file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = lblPathFiles.Text;                
                openFileDialog.Filter = allFilter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.ShowDialog();                
            }   */
            }//open a file

        }

        private void btnShowHistoryForm_Click(object sender, EventArgs e)
        {
            Controler.ShowHistory();
        }

        private void cmbBoxResearch_TextChanged(object sender, EventArgs e)
        {
            Controler.GetPath(lblPathFiles.Text);
            ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text));
        }

        private void lstBoxFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstBoxFileName.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                try
                {
                    if (lstBoxFileType.Items[index] != null)
                    {
                        //open file                
                        Process process = new Process();
                        process.StartInfo = new ProcessStartInfo()
                        {
                            UseShellExecute = true,
                            FileName = lstBoxFilePath.Items[index].ToString()
                        };
                        process.Start();
                    }
                }
                catch { }
                
            }
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.DateIndex = DateTime.Now.ToString();
            index.PathIndex = lblPathFiles.Text;

            Controler.UpdateIndexingHistory(index);
        }

        private void ShowResult(List<File> filesObtained)
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
                        cmbBoxExtensions.Items.Add(file.CurrentFile.Extension);
                    }
                }
                else
                {
                    lstBoxFileName.Items.Add($"{file.CurrentDirectory.Name}");
                    lstBoxFilePath.Items.Add($"{file.CurrentDirectory.FullName}");
                }
            }
        }
    }
}
