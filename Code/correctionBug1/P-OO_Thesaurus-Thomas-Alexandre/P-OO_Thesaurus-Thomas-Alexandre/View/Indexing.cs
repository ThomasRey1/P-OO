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

namespace P_OO_Thesaurus_Thomas_Alexandre
{

    public partial class Indexing : Form
    {
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }


        private bool _componentIsInitialize = false;
        private DriveInfo[] _allDrive = DriveInfo.GetDrives();        

        public Indexing()
        {
            InitializeComponent();
            //tool tip
            tlTip.SetToolTip(btnPlusFilter, "Indique que dans ce mot DOIT être contenu dans la recherche");
            tlTip.SetToolTip(btnMinusFilter, "Indique que dans ce mot NE DOIT PAS être contenu dans la recherche");
            tlTip.SetToolTip(btnANDFilter, "Indique que dans ce mot ET un autre doivent être contenu dans la recherche");
            tlTip.SetToolTip(btnORFilter,"Indique que dans ce mot OU un autre doivent être contenu dans la recherche");

            EventHandler handler = (s, e) =>
            {
                if (s == lstBoxFileName)
                {
                    lstBoxFileType.TopIndex = lstBoxFileName.TopIndex;
                    lstBoxFileSize.TopIndex = lstBoxFileName.TopIndex;
                    lstBoxFilePath.TopIndex = lstBoxFileName.TopIndex;
                }
            };

            this.lstBoxFileName.MouseCaptureChanged += handler;
            this.lstBoxFileName.MouseHover += handler;
            this.lstBoxFileName.MouseLeave += handler;
        }
        public void Start()
        {

            foreach (DriveInfo drive in _allDrive)
            {
                if (drive.DriveType != DriveType.CDRom && !Controler.GetPath(drive.Name, cmbBoxDisk.Text))
                {
                    cmbBoxDisk.Items.Add(drive.Name);
                }
            }
            lblPathFiles.Text = cmbBoxDisk.Text;
            lstBoxFilePath.AutoScrollOffset = new Point(0, 0);
            cmbBoxExtensions.SelectedIndex = 0;
            _componentIsInitialize = true;
            cmbBoxDisk.SelectedIndex = 0;
            cmbBoxDisk.Items.Add("Site Web");
        }
        private void cmbBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxDisk.Text != "Site Web")
            {
                lblFilePath.Width = 357;
                lstBoxFilePath.Width = 357;
                lblFilePath.Location = new Point(683, -1);
                lstBoxFilePath.Location = new Point(683, 24);
            }
            else
            {
                lblFilePath.Width += 305;
                lstBoxFilePath.Width += 305;
                lblFilePath.Location = new Point(435, -1);
                lstBoxFilePath.Location = new Point(435, 24);
            }

            lblPathFiles.Text = cmbBoxDisk.Text;
            Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text); 
            ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
        }

        private void btnPlusFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('<');
        }

        private void btnMinusFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('>');
        }

        private void btnANDFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('?');
        }

        private void btnORFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('|');
        }
         
        private void BtnFilterClick(char filter)
        {
            cmbBoxResearch.Text += filter;
            cmbBoxResearch.Focus();
            cmbBoxResearch.Select(cmbBoxResearch.Text.Length, 0);
        }

        private void picBoxDiskNext_Click(object sender, EventArgs e)
        {
            if (cmbBoxDisk.SelectedIndex != cmbBoxDisk.Items.Count - 1)
            {
                cmbBoxDisk.SelectedIndex += 1;
            }
        }

        private void picBoxDiskBefore_Click(object sender, EventArgs e)
        {
            if (cmbBoxDisk.SelectedIndex != 0)
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
                lblPathFiles.Text = fbd.SelectedPath;
                cmbBoxDisk.SelectedItem = (fbd.SelectedPath).Substring(0, 3);
                Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
            {/* 
            ////////Make the filter with all existing extension
            string allFilter = "All Files (*.*)|*.*";
            for (int i = 0; i < cmbBoxExtensions.Items.Count; i++)
            {
                string currentFilter = cmbBoxExtensions.GetItemText(cmbBoxExtensions.Items[i]);
                allFilter += "|" + currentFilter + " Files (*" + currentFilter + ")|*" + currentFilter;
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
            Controler.ViewHistory.StartPosition = FormStartPosition.CenterScreen;
            Controler.ViewHistory.Show();
            Controler.View.Hide();
            Controler.ViewHistory.Activate();
            Controler.ViewHistory.GetAndShowHistory();
        }

        private void cmbBoxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_componentIsInitialize == true)
            {
                Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }

        private void cmbBoxResearch_TextChanged(object sender, EventArgs e)
        {
            Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text); 
            if (cmbBoxDisk.Text != "Site Web")
            {
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }

        private void lstBoxFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstBoxFileName.IndexFromPoint(e.Location);            
            if (index != ListBox.NoMatches)
            {
                if (cmbBoxDisk.Text != "Site Web")
                {
                    if (lstBoxFileType.Items[index].ToString() == "Dossier")
                    {
                        lblPathFiles.Text += lstBoxFileName.SelectedItem.ToString() + @"\";
                        if (Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text))
                        {
                            picboxPreviousFile_Click(null, e);
                            MessageBox.Show("Cette accès vous a été refusé", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
                        }
                    }
                    else
                    {
                        //open file
                        File.OpenFile(lstBoxFilePath.Items[index].ToString());
                    }
                }
                else
                {
                    if (lstBoxFileType.Items[index].ToString() == "url")
                    {
                        //open file
                        File.OpenUrl(lstBoxFilePath.Items[index].ToString(), cmbBoxResearch.Text);
                    }
                }
            }
        }
        

        private void picboxPreviousFile_Click(object sender, EventArgs e)
        {
            string[] currentPath = lblPathFiles.Text.Split(@"\");
            if (currentPath.Length > 2)
            {
                lblPathFiles.Text = string.Empty;
                for (int i = 0; i < currentPath.Length - 2; i++)
                {
                    lblPathFiles.Text += currentPath[i] + @"\";
                }
                Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }
        private void ShowResult(List<File> filesObtained)
        {
            lstBoxFileName.Items.Clear();
            lstBoxFileType.Items.Clear();
            lstBoxFileSize.Items.Clear();
            lstBoxFilePath.Items.Clear();
            if (cmbBoxDisk.Text != "Site Web")
            {
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
                        lstBoxFileSize.Items.Add($" ");
                        lstBoxFilePath.Items.Add($"{file.CurrentDirectory.FullName}");
                    }
                }
            }
            else
            {
                if(filesObtained != null)
                {
                    foreach (File file in filesObtained)
                    {
                        if(file.TypeNode == "image")
                        {
                            lstBoxFileName.Items.Add($"{file.CurrentNode.Attributes[0].Value}");
                            if(file.CurrentNode.Attributes.Count == 2)
                            {
                                lstBoxFilePath.Items.Add($"{file.CurrentNode.Attributes[1].Value}");
                            }
                        }
                        else
                        {
                            lstBoxFileName.Items.Add($"{Controler.InnerHtmlBalise(file)}"); 
                            lstBoxFilePath.Items.Add($"{file.CurrentNode.GetAttributeValue("href", string.Empty)}");
                        }
                        lstBoxFileType.Items.Add($"{file.TypeNode}");
                        lstBoxFileSize.Items.Add($" ");
                        
                    }
                }
            }
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            Index index = new Index(DateTime.Now.ToString(), lblPathFiles.Text);
            List<string> filesPath = new List<string>();
            foreach (string path in lstBoxFilePath.Items)
            {
                filesPath.Add(path);
            }

            Controler.UpdateIndexingHistory(index, lblPathFiles.Text, filesPath);
            MessageBox.Show("Indexation réussie");
        }

        private void cmbBoxResearch_Leave(object sender, EventArgs e)
        {
            if (cmbBoxDisk.Text == "Site Web")
            {
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }
    }
}
