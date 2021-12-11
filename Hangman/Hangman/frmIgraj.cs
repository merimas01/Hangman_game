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
            Stringovi = new List<string>() { "KOCKA", "TELEVIZOR", "MIMIKRIJA", "ATAVIZAM", "MOBITEL" };
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
                novi += "-"; 
            }
            lblNepoznataRijec.Text = novi;
            BrojacPokusaja = 0;
            lblPoruka.Text = "";
        }
        bool JeLiPogodjenoSlovo()
        {
            if (txtUnos.Text.Length == 1) //ako je ukucao samo jedno slovo
            {
                bool valid = false;
                for (int i = 0; i < RandomRijec.Length; i++)
                {
                    if (txtUnos.Text.ToUpper()[0] == RandomRijec[i])
                    {
                        string noviText = "";
                        for (int j = 0; j < lblNepoznataRijec.Text.Length; j++)
                        {
                            if (j == i)
                                noviText += txtUnos.Text.ToUpper();
                            else
                                noviText += lblNepoznataRijec.Text[j];                           
                        }
                        lblNepoznataRijec.Text = noviText;
                        valid = true;                     
                    }
                    else
                        valid = false;

                    if (lblNepoznataRijec.Text == RandomRijec && BrojacPokusaja < 7)
                    {
                        lblPoruka.Text = "Bravo!!!";
                        txtUnos.Enabled = false;
                        txtUnos.BackColor = Color.LimeGreen;
                        BrojacPokusaja = 0;
                        btnPotvrdi.Enabled = false;
                        BrojPobjeda++;
                    }
                }
                return valid;
            }        
            return false; 
        }
        bool JeLiPogodjenaRijec()
        {
            if (txtUnos.Text.ToUpper() == RandomRijec)
            {
                OnemoguciUnos();
                lblNepoznataRijec.Text = RandomRijec;
                return true;
            }
            return false;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtUnos.Text != "")
            {
                ++BrojacPokusaja;
                lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                lblPoruka.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show("Niste nista napisali... Jeste li sigurni da zelite potvrditi?", "Potvrdi unos", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    ++BrojacPokusaja;
                    lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                }
            }
          
           if (BrojacPokusaja < 7) 
           {
               txtUnos.BackColor = Color.White;
               txtUnos.Enabled = true;
           }
                    
           if (!string.IsNullOrWhiteSpace(txtUnos.Text)) 
           {
               if(!JeLiPogodjenaRijec() && !JeLiPogodjenoSlovo())
               {
                   txtUnos.Text = "";
               }
               if (JeLiPogodjenaRijec())
               {
                   lblPoruka.Text = "Bravo! Pogodili ste trazenu rijec!";
                    BrojPobjeda++;
               }
           }
           if (BrojacPokusaja == 7)
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
