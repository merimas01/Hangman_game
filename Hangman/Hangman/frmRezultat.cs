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
        private string poruka = "";
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
                $"Vaš ukupan procenat uspjeha je {procenat}%."+Environment.NewLine+Environment.NewLine;

            if (procenat == 0)
                poruka = "Ajmo malo to bolje!";
            else if (procenat > 0 && procenat <= 30)
                poruka = "Dobar rezultat ali možete Vi i bolje ;)";
            else if (procenat > 30 && procenat <= 60)
                poruka = "Vrlo dobar rezultat :)";
            else if (procenat > 60 && procenat <= 90)
                poruka = "Sjajan rezultat!";
            else if (procenat > 90 && procenat <= 100)
                poruka = "Odličan rezultat! Čestitamo!";

            lblTekst.Text += poruka + Environment.NewLine;
        }
    }
}
