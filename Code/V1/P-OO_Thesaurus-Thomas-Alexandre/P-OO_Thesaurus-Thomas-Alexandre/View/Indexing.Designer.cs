
namespace P_OO_Thesaurus_Thomas_Alexandre
{
    partial class Indexing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indexing));
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblNumberResults = new System.Windows.Forms.Label();
            this.cmbBoxExtensions = new System.Windows.Forms.ComboBox();
            this.cmbBoxResearch = new System.Windows.Forms.ComboBox();
            this.cmbBoxDisk = new System.Windows.Forms.ComboBox();
            this.btnPlusFilter = new System.Windows.Forms.Button();
            this.btnMinusFilter = new System.Windows.Forms.Button();
            this.btnANDFilter = new System.Windows.Forms.Button();
            this.btnORFilter = new System.Windows.Forms.Button();
            this.picBoxDiskBefore = new System.Windows.Forms.PictureBox();
            this.picBoxDiskNext = new System.Windows.Forms.PictureBox();
            this.lblPathFiles = new System.Windows.Forms.Label();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnShowHistoryForm = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.pnlFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiskBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiskNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiles
            // 
            this.pnlFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiles.Controls.Add(this.lblFilePath);
            this.pnlFiles.Controls.Add(this.lblFileSize);
            this.pnlFiles.Controls.Add(this.lblFileType);
            this.pnlFiles.Controls.Add(this.lblFileName);
            this.pnlFiles.Controls.Add(this.lblNumberResults);
            this.pnlFiles.Location = new System.Drawing.Point(13, 122);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(1040, 423);
            this.pnlFiles.TabIndex = 0;
            // 
            // lblFilePath
            // 
            this.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilePath.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFilePath.Location = new System.Drawing.Point(683, -1);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(357, 26);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "Chemin d\'accès";
            // 
            // lblFileSize
            // 
            this.lblFileSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileSize.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileSize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFileSize.Location = new System.Drawing.Point(532, -1);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(153, 26);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.Text = "Taille";
            // 
            // lblFileType
            // 
            this.lblFileType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileType.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFileType.Location = new System.Drawing.Point(380, -1);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(153, 26);
            this.lblFileType.TabIndex = 2;
            this.lblFileType.Text = "Type";
            // 
            // lblFileName
            // 
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFileName.Location = new System.Drawing.Point(-1, -1);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(382, 26);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Nom du fichier";
            // 
            // lblNumberResults
            // 
            this.lblNumberResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberResults.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberResults.Location = new System.Drawing.Point(-1, 392);
            this.lblNumberResults.Name = "lblNumberResults";
            this.lblNumberResults.Size = new System.Drawing.Size(1040, 30);
            this.lblNumberResults.TabIndex = 0;
            this.lblNumberResults.Text = "0 résultats";
            // 
            // cmbBoxExtensions
            // 
            this.cmbBoxExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxExtensions.FormattingEnabled = true;
            this.cmbBoxExtensions.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".txt",
            ".exe",
            ".pdf"});
            this.cmbBoxExtensions.Location = new System.Drawing.Point(808, 69);
            this.cmbBoxExtensions.Name = "cmbBoxExtensions";
            this.cmbBoxExtensions.Size = new System.Drawing.Size(244, 23);
            this.cmbBoxExtensions.TabIndex = 3;
            // 
            // cmbBoxResearch
            // 
            this.cmbBoxResearch.FormattingEnabled = true;
            this.cmbBoxResearch.Location = new System.Drawing.Point(168, 69);
            this.cmbBoxResearch.Name = "cmbBoxResearch";
            this.cmbBoxResearch.Size = new System.Drawing.Size(612, 23);
            this.cmbBoxResearch.TabIndex = 2;
            // 
            // cmbBoxDisk
            // 
            this.cmbBoxDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDisk.FormattingEnabled = true;
            this.cmbBoxDisk.Location = new System.Drawing.Point(13, 69);
            this.cmbBoxDisk.Name = "cmbBoxDisk";
            this.cmbBoxDisk.Size = new System.Drawing.Size(125, 23);
            this.cmbBoxDisk.TabIndex = 1;
            this.cmbBoxDisk.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDisk_SelectedIndexChanged);
            // 
            // btnPlusFilter
            // 
            this.btnPlusFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusFilter.Location = new System.Drawing.Point(168, 22);
            this.btnPlusFilter.Name = "btnPlusFilter";
            this.btnPlusFilter.Size = new System.Drawing.Size(153, 41);
            this.btnPlusFilter.TabIndex = 4;
            this.btnPlusFilter.Text = "+";
            this.btnPlusFilter.UseVisualStyleBackColor = true;
            this.btnPlusFilter.Click += new System.EventHandler(this.btnPlusFilter_Click);
            // 
            // btnMinusFilter
            // 
            this.btnMinusFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinusFilter.Location = new System.Drawing.Point(321, 22);
            this.btnMinusFilter.Name = "btnMinusFilter";
            this.btnMinusFilter.Size = new System.Drawing.Size(153, 41);
            this.btnMinusFilter.TabIndex = 5;
            this.btnMinusFilter.Text = "-";
            this.btnMinusFilter.UseVisualStyleBackColor = true;
            this.btnMinusFilter.Click += new System.EventHandler(this.btnMinusFilter_Click);
            // 
            // btnANDFilter
            // 
            this.btnANDFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnANDFilter.Location = new System.Drawing.Point(474, 22);
            this.btnANDFilter.Name = "btnANDFilter";
            this.btnANDFilter.Size = new System.Drawing.Size(153, 41);
            this.btnANDFilter.TabIndex = 6;
            this.btnANDFilter.Text = "ET";
            this.btnANDFilter.UseVisualStyleBackColor = true;
            this.btnANDFilter.Click += new System.EventHandler(this.btnANDFilter_Click);
            // 
            // btnORFilter
            // 
            this.btnORFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnORFilter.Location = new System.Drawing.Point(627, 22);
            this.btnORFilter.Name = "btnORFilter";
            this.btnORFilter.Size = new System.Drawing.Size(153, 41);
            this.btnORFilter.TabIndex = 5;
            this.btnORFilter.Text = "OU";
            this.btnORFilter.UseVisualStyleBackColor = true;
            this.btnORFilter.Click += new System.EventHandler(this.btnORFilter_Click);
            // 
            // picBoxDiskBefore
            // 
            this.picBoxDiskBefore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxDiskBefore.BackgroundImage")));
            this.picBoxDiskBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxDiskBefore.Location = new System.Drawing.Point(13, 22);
            this.picBoxDiskBefore.Name = "picBoxDiskBefore";
            this.picBoxDiskBefore.Size = new System.Drawing.Size(42, 42);
            this.picBoxDiskBefore.TabIndex = 7;
            this.picBoxDiskBefore.TabStop = false;
            this.picBoxDiskBefore.Click += new System.EventHandler(this.picBoxDiskBefore_Click);
            // 
            // picBoxDiskNext
            // 
            this.picBoxDiskNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxDiskNext.BackgroundImage")));
            this.picBoxDiskNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxDiskNext.Location = new System.Drawing.Point(98, 22);
            this.picBoxDiskNext.Name = "picBoxDiskNext";
            this.picBoxDiskNext.Size = new System.Drawing.Size(42, 42);
            this.picBoxDiskNext.TabIndex = 8;
            this.picBoxDiskNext.TabStop = false;
            this.picBoxDiskNext.Click += new System.EventHandler(this.picBoxDiskNext_Click);
            // 
            // lblPathFiles
            // 
            this.lblPathFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathFiles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPathFiles.Location = new System.Drawing.Point(17, 561);
            this.lblPathFiles.Name = "lblPathFiles";
            this.lblPathFiles.Size = new System.Drawing.Size(506, 41);
            this.lblPathFiles.TabIndex = 9;
            this.lblPathFiles.Text = "K:/INF";
            this.lblPathFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDirectory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDirectory.Location = new System.Drawing.Point(522, 561);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(75, 41);
            this.btnOpenDirectory.TabIndex = 10;
            this.btnOpenDirectory.Text = "Ouvrir";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // btnShowHistoryForm
            // 
            this.btnShowHistoryForm.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowHistoryForm.Location = new System.Drawing.Point(675, 561);
            this.btnShowHistoryForm.Name = "btnShowHistoryForm";
            this.btnShowHistoryForm.Size = new System.Drawing.Size(153, 41);
            this.btnShowHistoryForm.TabIndex = 11;
            this.btnShowHistoryForm.Text = "Historique";
            this.btnShowHistoryForm.UseVisualStyleBackColor = true;
            this.btnShowHistoryForm.Click += new System.EventHandler(this.btnShowHistoryForm_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIndex.Location = new System.Drawing.Point(900, 561);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(153, 41);
            this.btnIndex.TabIndex = 12;
            this.btnIndex.Text = "Indexer";
            this.btnIndex.UseVisualStyleBackColor = true;
            // 
            // Indexing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnShowHistoryForm);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.lblPathFiles);
            this.Controls.Add(this.picBoxDiskNext);
            this.Controls.Add(this.picBoxDiskBefore);
            this.Controls.Add(this.btnORFilter);
            this.Controls.Add(this.btnANDFilter);
            this.Controls.Add(this.btnMinusFilter);
            this.Controls.Add(this.btnPlusFilter);
            this.Controls.Add(this.cmbBoxDisk);
            this.Controls.Add(this.cmbBoxResearch);
            this.Controls.Add(this.cmbBoxExtensions);
            this.Controls.Add(this.pnlFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indexing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Thésaurus - IE & CO";
            this.pnlFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiskBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiskNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.ComboBox cmbBoxExtensions;
        private System.Windows.Forms.ComboBox cmbBoxResearch;
        private System.Windows.Forms.ComboBox cmbBoxDisk;
        private System.Windows.Forms.Button btnPlusFilter;
        private System.Windows.Forms.Button btnMinusFilter;
        private System.Windows.Forms.Button btnANDFilter;
        private System.Windows.Forms.Button btnORFilter;
        private System.Windows.Forms.PictureBox picBoxDiskBefore;
        private System.Windows.Forms.PictureBox picBoxDiskNext;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblNumberResults;
        private System.Windows.Forms.Label lblPathFiles;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnShowHistoryForm;
        private System.Windows.Forms.Button btnIndex;
    }
}

