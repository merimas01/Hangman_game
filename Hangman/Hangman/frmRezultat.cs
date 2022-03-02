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
            var procenat = Math.Round(((frmIgraj.BrojPobjeda*1.0m) / (frmIgraj.BrojacNovaIgra)) * 100, 0);
            lblTekst.Text = $"Ostvarili ste {frmIgraj.BrojPobjeda} pobjeda od {frmIgraj.BrojacNovaIgra} započetih igri. " +
                $"Vaš ukupan procenat uspjeha je {procenat}%";    
        }
    }
}
