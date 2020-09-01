﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijkseLonenPW1
{
    public partial class readtextfile : Form
    {
        string filename;
        public readtextfile(string filename)
        {
            this.filename = filename;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtinhoud_TextChanged(object sender, EventArgs e)
        {

        }

        private void readtextfile_Load(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {

                string s = File.ReadAllText(filename);
                txtinhoud.Text = s;
            }

        }
    }
}
