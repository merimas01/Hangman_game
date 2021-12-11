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
            var procenat = ((frmIgraj.BrojPobjeda*1.0f) / (frmIgraj.BrojacNovaIgra + 1)) * 100; //ovo +1 je inicijalna igra kad kliknemo na shvatam
            lblTekst.Text = $"Ostvarili ste {frmIgraj.BrojPobjeda} pobjeda od {frmIgraj.BrojacNovaIgra + 1} zapocetih igri. Vas ukupan procenat uspjeha je {procenat}%";
        }
    }
}
