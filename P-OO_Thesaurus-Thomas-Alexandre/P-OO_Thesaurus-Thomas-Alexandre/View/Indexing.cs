///ETML
///Auteur : Alexandre King
///Date :07.03.22
///Description :Main view of the program
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
        /// <summary>
        /// define the controler of this view
        /// </summary>
        private Controler _controler;
        
        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }

        //Detect if all the componet is already initialize or not
        private bool _componentIsInitialize = false;
        //table of DriveInfo that contain all the drivers of the pc
        private DriveInfo[] _allDrive = DriveInfo.GetDrives();  
        
        /// <summary>
        /// Main Function
        /// </summary>
        public Indexing()
        {
            InitializeComponent();
            //tool tip to help the user
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

        /// <summary>
        /// is called when the program is started
        /// </summary>
        public void Start()
        {
            //get all the driver of the pc
            foreach (DriveInfo drive in _allDrive)
            {
                if (drive.DriveType != DriveType.CDRom && !Controler.GetPath(drive.Name, cmbBoxDisk.Text))
                {
                    cmbBoxDisk.Items.Add(drive.Name);
                }
            }
            //set the current path to driver that's currently selected
            lblPathFiles.Text = cmbBoxDisk.Text;
            //set the autoScrollOffSet point to 0,0
            lstBoxFilePath.AutoScrollOffset = new Point(0, 0);
            //select the first extension of the combobox of extension filter
            cmbBoxExtensions.SelectedIndex = 0;
            //set the variable to true to say that the component is initialize
            _componentIsInitialize = true;
            //select the first driver available
            cmbBoxDisk.SelectedIndex = 0;
            //add the choice "site web" to the driver list
            cmbBoxDisk.Items.Add("Site Web");
        }

        private void cmbBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the site web isn't selected
            if (cmbBoxDisk.Text != "Site Web")
            {
                //set size and location of labels
                lblFilePath.Width = 357;
                lstBoxFilePath.Width = 357;
                lblFilePath.Location = new Point(683, -1);
                lstBoxFilePath.Location = new Point(683, 24);
            }
            else
            {
                //set size and location of labels
                lblFilePath.Width += 305;
                lstBoxFilePath.Width += 305;
                lblFilePath.Location = new Point(435, -1);
                lstBoxFilePath.Location = new Point(435, 24);
            }
            //when index of list change, also change current path
            lblPathFiles.Text = cmbBoxDisk.Text;
            //call controler to get the path
            Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text); 
            //show all files found
            ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
        }

        //when the plus filter button is pressed
        private void btnPlusFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('<');
        }

        //when the minus filter button is pressed
        private void btnMinusFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('>');
        }

        //when the and filter button is pressed
        private void btnANDFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('?');
        }

        //when the or filter button is pressed
        private void btnORFilter_Click(object sender, EventArgs e)
        {
            BtnFilterClick('|');
        }

        /// <summary>
        /// when a filter button is pressed
        /// </summary>
        /// <param name="filter">char thaht need to be placed in the research bar</param>
        private void BtnFilterClick(char filter)
        {
            // add the filter text to the research bar
            cmbBoxResearch.Text += filter;
            //focus on the research bar
            cmbBoxResearch.Focus();
            //place cursor at the end of the bar
            cmbBoxResearch.Select(cmbBoxResearch.Text.Length, 0);
        }

        private void picBoxDiskNext_Click(object sender, EventArgs e)
        {
            //go to the next driver if it's not the last one of the list
            if (cmbBoxDisk.SelectedIndex != cmbBoxDisk.Items.Count - 1)
            {
                cmbBoxDisk.SelectedIndex += 1;
            }
        }

        private void picBoxDiskBefore_Click(object sender, EventArgs e)
        {
            //go to the next driver if it's not the first one of the list
            if (cmbBoxDisk.SelectedIndex != 0)
            {
                cmbBoxDisk.SelectedIndex -= 1;
            }
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            //create a folder Browser Dialog so the user can choose a folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //will open the dialog at the current path 
            fbd.SelectedPath = lblPathFiles.Text;
            //the description of what to do
            fbd.Description = "--Veuillez séléctionner un dossier à indexer--";
            //user can't create new folder
            fbd.ShowNewFolderButton = false;
            //won't auto upgrade
            fbd.AutoUpgradeEnabled = false;
            //if the result of the dialog is ok
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //change the current path
                lblPathFiles.Text = fbd.SelectedPath;
                //change the driver
                cmbBoxDisk.SelectedItem = (fbd.SelectedPath).Substring(0, 3);
                //get the current path
                Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text);
                //show all files found
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }

        }

        private void btnShowHistoryForm_Click(object sender, EventArgs e)
        {
            //show the history and define the form attributs
            Controler.ViewHistory.StartPosition = FormStartPosition.CenterScreen;
            Controler.ViewHistory.Show();
            Controler.View.Hide();
            Controler.ViewHistory.Activate();
            Controler.ViewHistory.GetAndShowHistory();
        }

        private void cmbBoxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if componet is initialize, update the file 
            if (_componentIsInitialize == true)
            {
                Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text);
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }

        private void cmbBoxResearch_TextChanged(object sender, EventArgs e)
        {
            //get the path 
            Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text); 
            //if site web isn't selected, show files 
            if (cmbBoxDisk.Text != "Site Web")
            {
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }

        private void lstBoxFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //index of selected file or folder
            int index = this.lstBoxFileName.IndexFromPoint(e.Location);            
            //if index isn't out of range
            if (index != ListBox.NoMatches)
            {
                //if not a site web
                if (cmbBoxDisk.Text != "Site Web")
                {
                    //check if it's a file or folder
                    if (lstBoxFileType.Items[index].ToString() == "Dossier")
                    {
                        //if folder change current path
                        lblPathFiles.Text += lstBoxFileName.SelectedItem.ToString() + @"\";
                        //if the user can't access
                        if (Controler.GetPath(lblPathFiles.Text, cmbBoxDisk.Text))
                        {
                            picboxPreviousFile_Click(null, e);
                            MessageBox.Show("Cette accès vous a été refusé", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            //show files 
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
                    //if it's a site web
                    if (lstBoxFileType.Items[index].ToString() == "url")
                    {
                        //open file
                        File.OpenUrl(lstBoxFilePath.Items[index].ToString(), cmbBoxResearch.Text);
                    }
                }
            }
        }
        
        //got to the previous folder of the current path
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

        /// <summary>
        /// Show the result of the files in the current folder
        /// </summary>
        /// <param name="filesObtained">list of the file that is obtained</param>
        private void ShowResult(List<File> filesObtained)
        {
            //clear all listbox
            lstBoxFileName.Items.Clear();
            lstBoxFileType.Items.Clear();
            lstBoxFileSize.Items.Clear();
            lstBoxFilePath.Items.Clear();
            if (cmbBoxDisk.Text != "Site Web")
            {
                //foreach file add is name, extension, length, path to a listbox
                foreach (File file in filesObtained)
                {
                    if (file.CurrentFile != null)
                    {
                        lstBoxFileName.Items.Add($"{file.CurrentFile.Name}");
                        lstBoxFileType.Items.Add($"{file.CurrentFile.Extension}");
                        lstBoxFileSize.Items.Add($"{file.CurrentFile.Length}");
                        lstBoxFilePath.Items.Add($"{file.CurrentFile.FullName}");

                        //if extension filter is on
                        if (!cmbBoxExtensions.Items.Contains(file.CurrentFile.Extension))
                        {
                            //if file extension is "fichier"
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
                                //add all file with extension
                                cmbBoxExtensions.Items.Add(file.CurrentFile.Extension);
                            }
                        }
                    }
                    else
                    {
                        //if not a file add folder
                        lstBoxFileName.Items.Add($"{file.CurrentDirectory.Name}");
                        lstBoxFileType.Items.Add($"Dossier");
                        lstBoxFileSize.Items.Add($" ");
                        lstBoxFilePath.Items.Add($"{file.CurrentDirectory.FullName}");
                    }
                }
            }
            else
            {
                //if is from the web
                if(filesObtained != null)
                {
                    //show each image and link founded
                    foreach (File file in filesObtained)
                    {
                        //if is a image
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

        //index all the files at the current path (include all folder and file ih folder)
        private void btnIndex_Click(object sender, EventArgs e)
        {
            //define a new index
            Index index = new Index(DateTime.Now.ToString(), lblPathFiles.Text);
            //create a list of path
            List<string> filesPath = new List<string>();
            //get all the paths
            foreach (string path in lstBoxFilePath.Items)
            {
                filesPath.Add(path);
            }
            //update the history
            Controler.UpdateIndexingHistory(index, lblPathFiles.Text, filesPath);
            //show that indexation gone right
            MessageBox.Show("Indexation réussie");
        }

        private void cmbBoxResearch_Leave(object sender, EventArgs e)
        {
            //show result when web only when the research bar is leave
            if (cmbBoxDisk.Text == "Site Web")
            {
                ShowResult(Controler.Search(cmbBoxResearch.Text, cmbBoxExtensions.Text, lblNumberResults, cmbBoxDisk.Text));
            }
        }
    }
}
