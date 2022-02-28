﻿using System;
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
        public History()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnIndexingForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indexing form = new Indexing();
            form.StartPosition = FormStartPosition.CenterScreen; 
            form.Show();
        }
    }
}
