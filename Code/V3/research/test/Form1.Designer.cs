
namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxResearch = new System.Windows.Forms.ComboBox();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lbxFile = new System.Windows.Forms.ListBox();
            this.cbxExtension = new System.Windows.Forms.ComboBox();
            this.pnlFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxResearch
            // 
            this.cbxResearch.FormattingEnabled = true;
            this.cbxResearch.Location = new System.Drawing.Point(300, 35);
            this.cbxResearch.Name = "cbxResearch";
            this.cbxResearch.Size = new System.Drawing.Size(121, 21);
            this.cbxResearch.TabIndex = 0;
            this.cbxResearch.TextChanged += new System.EventHandler(this.cmbBoxResearch_TextChanged);
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFiles.Controls.Add(this.lblCount);
            this.pnlFiles.Controls.Add(this.lbxFile);
            this.pnlFiles.Location = new System.Drawing.Point(128, 106);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(623, 304);
            this.pnlFiles.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 283);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label1";
            // 
            // lbxFile
            // 
            this.lbxFile.FormattingEnabled = true;
            this.lbxFile.Location = new System.Drawing.Point(0, 3);
            this.lbxFile.Name = "lbxFile";
            this.lbxFile.Size = new System.Drawing.Size(589, 277);
            this.lbxFile.TabIndex = 1;
            this.lbxFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxFile_MouseDoubleClick);
            // 
            // cbxExtension
            // 
            this.cbxExtension.FormattingEnabled = true;
            this.cbxExtension.Location = new System.Drawing.Point(525, 35);
            this.cbxExtension.Name = "cbxExtension";
            this.cbxExtension.Size = new System.Drawing.Size(121, 21);
            this.cbxExtension.TabIndex = 2;
            this.cbxExtension.SelectedIndexChanged += new System.EventHandler(this.cbxExtension_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxExtension);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.cbxResearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlFiles.ResumeLayout(false);
            this.pnlFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxResearch;
        public System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.ListBox lbxFile;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cbxExtension;
    }
}

