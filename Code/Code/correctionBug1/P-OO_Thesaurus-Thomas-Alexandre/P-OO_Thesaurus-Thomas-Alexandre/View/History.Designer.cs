
namespace P_OO_Thesaurus_Thomas_Alexandre
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.btnReturnIndexingForm = new System.Windows.Forms.Button();
            this.btnORFilter = new System.Windows.Forms.Button();
            this.btnANDFilter = new System.Windows.Forms.Button();
            this.btnMinusFilter = new System.Windows.Forms.Button();
            this.btnPlusFilter = new System.Windows.Forms.Button();
            this.cmbBoxResearch = new System.Windows.Forms.ComboBox();
            this.lblNumberResults = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblIndexingDate = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lstBoxFileIndexingDate = new System.Windows.Forms.ListBox();
            this.lstBoxFilePath = new System.Windows.Forms.ListBox();
            this.lstBoxFileNumber = new System.Windows.Forms.ListBox();
            this.pnlFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturnIndexingForm
            // 
            this.btnReturnIndexingForm.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnIndexingForm.Location = new System.Drawing.Point(12, 33);
            this.btnReturnIndexingForm.Name = "btnReturnIndexingForm";
            this.btnReturnIndexingForm.Size = new System.Drawing.Size(131, 70);
            this.btnReturnIndexingForm.TabIndex = 0;
            this.btnReturnIndexingForm.Text = "Retour";
            this.btnReturnIndexingForm.UseVisualStyleBackColor = true;
            this.btnReturnIndexingForm.Click += new System.EventHandler(this.btnReturnIndexingForm_Click);
            // 
            // btnORFilter
            // 
            this.btnORFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnORFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnORFilter.Location = new System.Drawing.Point(836, 33);
            this.btnORFilter.Name = "btnORFilter";
            this.btnORFilter.Size = new System.Drawing.Size(153, 41);
            this.btnORFilter.TabIndex = 9;
            this.btnORFilter.Text = "OU";
            this.btnORFilter.UseVisualStyleBackColor = true;
            // 
            // btnANDFilter
            // 
            this.btnANDFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnANDFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnANDFilter.Location = new System.Drawing.Point(683, 33);
            this.btnANDFilter.Name = "btnANDFilter";
            this.btnANDFilter.Size = new System.Drawing.Size(153, 41);
            this.btnANDFilter.TabIndex = 11;
            this.btnANDFilter.Text = "ET";
            this.btnANDFilter.UseVisualStyleBackColor = true;
            // 
            // btnMinusFilter
            // 
            this.btnMinusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinusFilter.Location = new System.Drawing.Point(530, 33);
            this.btnMinusFilter.Name = "btnMinusFilter";
            this.btnMinusFilter.Size = new System.Drawing.Size(153, 41);
            this.btnMinusFilter.TabIndex = 10;
            this.btnMinusFilter.Text = "SANS";
            this.btnMinusFilter.UseVisualStyleBackColor = true;
            // 
            // btnPlusFilter
            // 
            this.btnPlusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusFilter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusFilter.Location = new System.Drawing.Point(377, 33);
            this.btnPlusFilter.Name = "btnPlusFilter";
            this.btnPlusFilter.Size = new System.Drawing.Size(153, 41);
            this.btnPlusFilter.TabIndex = 8;
            this.btnPlusFilter.Text = "AVEC";
            this.btnPlusFilter.UseVisualStyleBackColor = true;
            // 
            // cmbBoxResearch
            // 
            this.cmbBoxResearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbBoxResearch.FormattingEnabled = true;
            this.cmbBoxResearch.Location = new System.Drawing.Point(377, 80);
            this.cmbBoxResearch.Name = "cmbBoxResearch";
            this.cmbBoxResearch.Size = new System.Drawing.Size(612, 23);
            this.cmbBoxResearch.TabIndex = 7;            
            this.cmbBoxResearch.TextChanged += new System.EventHandler(this.cmbBoxResearch_TextChanged);
            // 
            // lblNumberResults
            // 
            this.lblNumberResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberResults.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberResults.Location = new System.Drawing.Point(-1, 387);
            this.lblNumberResults.Name = "lblNumberResults";
            this.lblNumberResults.Size = new System.Drawing.Size(1040, 35);
            this.lblNumberResults.TabIndex = 0;
            this.lblNumberResults.Text = "0 résultats";
            // 
            // lblFileName
            // 
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFileName.Location = new System.Drawing.Point(-1, -1);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(53, 26);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "N°";
            // 
            // lblIndexingDate
            // 
            this.lblIndexingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIndexingDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndexingDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIndexingDate.Location = new System.Drawing.Point(681, -1);
            this.lblIndexingDate.Name = "lblIndexingDate";
            this.lblIndexingDate.Size = new System.Drawing.Size(358, 26);
            this.lblIndexingDate.TabIndex = 3;
            this.lblIndexingDate.Text = "Date d\'Indexation";
            // 
            // lblFilePath
            // 
            this.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilePath.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFilePath.Location = new System.Drawing.Point(51, -1);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(631, 26);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "Chemin d\'accès";
            // 
            // pnlFiles
            // 
            this.pnlFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiles.Controls.Add(this.lstBoxFileIndexingDate);
            this.pnlFiles.Controls.Add(this.lstBoxFilePath);
            this.pnlFiles.Controls.Add(this.lstBoxFileNumber);
            this.pnlFiles.Controls.Add(this.lblFilePath);
            this.pnlFiles.Controls.Add(this.lblIndexingDate);
            this.pnlFiles.Controls.Add(this.lblFileName);
            this.pnlFiles.Controls.Add(this.lblNumberResults);
            this.pnlFiles.Location = new System.Drawing.Point(12, 138);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(1040, 423);
            this.pnlFiles.TabIndex = 12;
            // 
            // lstBoxFileIndexingDate
            // 
            this.lstBoxFileIndexingDate.FormattingEnabled = true;
            this.lstBoxFileIndexingDate.ItemHeight = 15;
            this.lstBoxFileIndexingDate.Location = new System.Drawing.Point(681, 24);
            this.lstBoxFileIndexingDate.Name = "lstBoxFileIndexingDate";
            this.lstBoxFileIndexingDate.Size = new System.Drawing.Size(358, 364);
            this.lstBoxFileIndexingDate.TabIndex = 7;
            // 
            // lstBoxFilePath
            // 
            this.lstBoxFilePath.FormattingEnabled = true;
            this.lstBoxFilePath.ItemHeight = 15;
            this.lstBoxFilePath.Location = new System.Drawing.Point(51, 24);
            this.lstBoxFilePath.Name = "lstBoxFilePath";
            this.lstBoxFilePath.Size = new System.Drawing.Size(631, 364);
            this.lstBoxFilePath.TabIndex = 6;
            // 
            // lstBoxFileNumber
            // 
            this.lstBoxFileNumber.FormattingEnabled = true;
            this.lstBoxFileNumber.ItemHeight = 15;
            this.lstBoxFileNumber.Location = new System.Drawing.Point(-1, 24);
            this.lstBoxFileNumber.Name = "lstBoxFileNumber";
            this.lstBoxFileNumber.Size = new System.Drawing.Size(53, 364);
            this.lstBoxFileNumber.TabIndex = 5;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.btnORFilter);
            this.Controls.Add(this.btnANDFilter);
            this.Controls.Add(this.btnMinusFilter);
            this.Controls.Add(this.btnPlusFilter);
            this.Controls.Add(this.cmbBoxResearch);
            this.Controls.Add(this.btnReturnIndexingForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "History - IE & CO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.History_FormClosing);
            this.pnlFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturnIndexingForm;
        private System.Windows.Forms.Button btnORFilter;
        private System.Windows.Forms.Button btnANDFilter;
        private System.Windows.Forms.Button btnMinusFilter;
        private System.Windows.Forms.Button btnPlusFilter;
        private System.Windows.Forms.ComboBox cmbBoxResearch;
        private System.Windows.Forms.Label lblNumberResults;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblIndexingDate;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.ListBox lstBoxFileIndexingDate;
        private System.Windows.Forms.ListBox lstBoxFilePath;
        private System.Windows.Forms.ListBox lstBoxFileNumber;
    }
}