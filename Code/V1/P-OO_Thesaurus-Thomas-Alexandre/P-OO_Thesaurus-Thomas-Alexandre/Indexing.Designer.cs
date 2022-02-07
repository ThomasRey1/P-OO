
namespace P_OO_Thesaurus_Thomas_Alexandre
{
    partial class indexing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexing));
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.cmbBoxExtensions = new System.Windows.Forms.ComboBox();
            this.cmbBoxResearch = new System.Windows.Forms.ComboBox();
            this.cmbBoxDisk = new System.Windows.Forms.ComboBox();
            this.btnPlusFilter = new System.Windows.Forms.Button();
            this.btnMinusFilter = new System.Windows.Forms.Button();
            this.btnANDFilter = new System.Windows.Forms.Button();
            this.btnORFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFiles
            // 
            this.pnlFiles.Location = new System.Drawing.Point(13, 122);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(1040, 423);
            this.pnlFiles.TabIndex = 0;
            // 
            // cmbBoxExtensions
            // 
            this.cmbBoxExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxExtensions.FormattingEnabled = true;
            this.cmbBoxExtensions.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".txt",
            ".exe"});
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
            this.cmbBoxResearch.TextChanged += new System.EventHandler(this.cmbBoxResearch_TextChanged);
            this.cmbBoxResearch.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBoxResearch_Validating);
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
            // indexing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.btnORFilter);
            this.Controls.Add(this.btnANDFilter);
            this.Controls.Add(this.btnMinusFilter);
            this.Controls.Add(this.btnPlusFilter);
            this.Controls.Add(this.cmbBoxDisk);
            this.Controls.Add(this.cmbBoxResearch);
            this.Controls.Add(this.cmbBoxExtensions);
            this.Controls.Add(this.pnlFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "indexing";
            this.Text = "Thésaurus - IE & CO";
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
    }
}

