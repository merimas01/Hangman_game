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
    public partial class frmRezultat : Form
    {
        public frmRezultat()
        {
            InitializeComponent();
        }

        private void frmRezultat_Load(object sender, EventArgs e)
        {
            if (frmIgraj.brojKlikanja % 2 != 0)
            {
                this.BackColor = Color.Black;
                lblTekst.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.SeaShell;
                lblTekst.ForeColor = Color.Black;
            }

            var procenat = Math.Round(((frmIgraj.BrojPobjeda*1.0m) / (frmIgraj.BrojacNovaIgra)) * 100, 0);
            lblTekst.Text = $"{frmHangman.Ime}, ostvarili ste {frmIgraj.BrojPobjeda} pobjeda od {frmIgraj.BrojacNovaIgra} započetih igri. " +
                $"Vaš trenutni ukupan procenat uspjeha je {procenat}%."+Environment.NewLine+Environment.NewLine;

            //int ukupnoRijeci = frmIgraj.ukupnoRijeciPocetna+frmIgraj.ukupnoRijeciLatinskeIzreke+frmIgraj.ukupnoRijeciIzazoviSe;
            //int pogodjeneRijeci = frmIgraj.BrojPobjeda;

            //lblTekst.Text += "Ukupno pogođenih riječi: " + pogodjeneRijeci +" od "+ ukupnoRijeci+" ("+
            //    Math.Round(((pogodjeneRijeci*1.0m)/ukupnoRijeci)*100, 0)+"%)."+Environment.NewLine;
        }
    }
}
