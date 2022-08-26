using System;
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
    public partial class frmLevels : Form
    {
        private string Easy = "easy";
        private string Hard = "hard";
        private string Advanced = "adv";
        public frmLevels()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmIgraj igraj = new frmIgraj(Easy);
            igraj.ShowDialog();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            frmIgraj igraj = new frmIgraj(Hard);
            igraj.ShowDialog();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            frmIgraj igraj = new frmIgraj(Advanced);
            igraj.ShowDialog();
        }

        private void frmLevels_Load(object sender, EventArgs e)
        {
            Text = "Nivoi";
        }
    }
}
