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
    public partial class frmIgraj : Form
    {
        public frmIgraj()
        {
            InitializeComponent();
            Stringovi = new List<string>() { "KOCKA", "TELEVIZOR", "MIMIKRIJA", "ATAVIZAM", "MOBITEL", "UB" };
        }
        public int BrojacPokusaja { get; set; } = 0;
        public List<string> Stringovi { get; set; }
        public string RandomRijec { get; set; } = "";
        public static int BrojPobjeda { get; set; } = 0;
        public static int BrojacNovaIgra { get; set; } = 0;

        string BirajRandomRijec()
        {
            var random = new Random();
            int i = random.Next(Stringovi.Count);
            while (Stringovi[i] == RandomRijec)
            {
                i = random.Next(Stringovi.Count);
            }
            return Stringovi[i];        
        }
        public void Igranje()
        {
            txtUnos.Enabled = true;
            RandomRijec = BirajRandomRijec();
            string novi = "";
            for (int i = 0; i < RandomRijec.Length; i++)
            {
                novi += "_ "; 
            }
            lblNepoznataRijec.Text = novi;
            BrojacPokusaja = 0;
            lblPoruka.Text = "";
        }
        bool JeLiPogodjenoSlovo()
        {
            bool valid = false;
            if (txtUnos.Text.Length == 1) //ako je ukucao samo jedno slovo
            {              
                for (int i = 0; i < RandomRijec.Length; i++)
                {
                    if (txtUnos.Text.ToUpper()[0] == RandomRijec[i])
                    {
                        string noviText = "";
                        for (int j = 0; j < lblNepoznataRijec.Text.Length; j++) 
                        {
                            if (j == (i * 2))
                            {
                                noviText += txtUnos.Text.ToUpper();
                            }
                            else
                                noviText += lblNepoznataRijec.Text[j];                           
                        }
                        lblNepoznataRijec.Text = noviText;                                              
                        valid = true;                     
                    }
                }               
            }
            return valid;
        }
        bool JeLiPogodjenaRijec()
        {
            if (txtUnos.Text.ToUpper() == RandomRijec)
            {
                OnemoguciUnos();
                lblNepoznataRijec.Text = RandomRijec;
                return true;
            }
            int k = 0;
            for(int i=0; i<lblNepoznataRijec.Text.Length; i += 2)
            {
                if (lblNepoznataRijec.Text[i] == RandomRijec[k])
                    k++;
            }
            if (k == RandomRijec.Length)
            {
                OnemoguciUnos();
                lblNepoznataRijec.Text = RandomRijec;
                return true;
            } 
            return false;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUnos.Text))
            {
                lblPoruka.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show("Niste nista napisali... Jeste li sigurni da zelite potvrditi unos?", "Potvrdi unos", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    ++BrojacPokusaja;
                    lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                }
            }
          
           if (BrojacPokusaja < 5) 
           {
               txtUnos.BackColor = Color.White;
               txtUnos.Enabled = true;
           }
                    
           if (!string.IsNullOrWhiteSpace(txtUnos.Text)) 
           {
               if(!JeLiPogodjenaRijec() && !JeLiPogodjenoSlovo())
               {
                   txtUnos.Text = "";
                   ++BrojacPokusaja;
                   lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                }
               if(JeLiPogodjenoSlovo())
               {
                    txtUnos.Text = "";
               }
               if (JeLiPogodjenaRijec())
               {
                   lblPoruka.Text = "Bravo! Pogodili ste trazenu rijec!";
                   BrojPobjeda++;
               }
           }
           if (BrojacPokusaja == 5)
           {
                OnemoguciUnos();
                txtUnos.Text = RandomRijec;
           }          
        }
        private void OnemoguciUnos()
        {
            txtUnos.BackColor = Color.Red;
            txtUnos.Enabled = false;
            lblPoruka.Text = "Pokusajte ponovo klikom na >>nova igra<< !";
            BrojacPokusaja = 0;
            lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
            btnPotvrdi.Enabled = false;
        }
        private void Resetuj()
        {
            BrojacPokusaja = 0;
            lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
            txtUnos.Text = "";
            txtUnos.BackColor = Color.White;
            btnPotvrdi.Enabled = true;
            txtUnos.Text = "";
        }
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            BrojacNovaIgra++;
            Resetuj();
            Igranje();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            new frmRezultat().ShowDialog();
        }
    }
}
