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
    public partial class frmHangman : Form
    {
        public static string Ime = "";
        public frmHangman()
        {
            InitializeComponent();
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            new frmLevels().ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Validator.ValidirajKontrolu(textBox1, err, "Obavezan unos"))
                btnZapocni.Enabled = true;          
            else
                btnZapocni.Enabled = false;

            Ime = textBox1.Text;
        }
    }
}
