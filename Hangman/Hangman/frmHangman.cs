﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        public frmHangman()
        {
            InitializeComponent();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            new frmLevels().ShowDialog();
        }
    }
}
