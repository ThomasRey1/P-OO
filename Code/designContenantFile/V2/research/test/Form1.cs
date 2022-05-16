﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        Research Research = new Research();
        List<File> list;
        public Form1()
        {
            InitializeComponent();
            list = Research.Search(cbxResearch.Text, cbxExtension.Text, lbxFile);
            cbxResearch.Items.Add(cbxResearch.Text);
            cbxExtension.Items.Add(cbxResearch.Text);
            foreach (File item in list)
            {
                cbxResearch.Items.Add(item.CurrentFile.Name);
                if (!cbxExtension.Items.Contains(item.CurrentFile.Extension))
                { 
                    cbxExtension.Items.Add(item.CurrentFile.Extension);
                }
            }
            cbxResearch.SelectionStart = cbxResearch.Text.Length;

            lblCount.Text = $"{Research.CountResult()} Result";
        }

        private void cmbBoxResearch_TextChanged(object sender, EventArgs e)
        {
            list = Research.Search(cbxResearch.Text, cbxExtension.Text, lbxFile);

            cbxResearch.Items.Clear();
            cbxResearch.Items.Add(cbxResearch.Text);
            foreach (File item in list)
            {
                cbxResearch.Items.Add(item.CurrentFile.Name);
                if (!cbxExtension.Items.Contains(item.CurrentFile.Extension))
                {
                    cbxExtension.Items.Add(item.CurrentFile.Extension);
                }
            }
            cbxResearch.SelectionStart = cbxResearch.Text.Length;

            lblCount.Text = $"{Research.CountResult()} Result";
        }

        private void cbxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            Research.Search(cbxResearch.Text, cbxExtension.Text, lbxFile);
        }
    }
}
