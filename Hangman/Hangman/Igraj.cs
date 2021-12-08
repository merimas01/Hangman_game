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
    public partial class Igraj : Form
    {
        public Igraj()
        {
            InitializeComponent();
        }
        public int BrojacPokusaja { get; set; } = 0;
        public List<string> Stringovi { get; set; } = new List<string>();
        public string RandomRijec { get; set; } 
        void GenerisanjeRijeciZaPogadjanje()
        {
            Stringovi.Add("KOCKA");
            Stringovi.Add("TELEVIZOR");
            Stringovi.Add("BANANA");
            Stringovi.Add("PROZOR");
            Stringovi.Add("MOBITEL");
        }
        string BirajRandomRijec()
        {
            GenerisanjeRijeciZaPogadjanje();
            if (Stringovi.Count > 0)
            {
                var random = new Random();
                int i = random.Next(Stringovi.Count);
                return Stringovi[i];
            }
            return null;         
        }
        public void Igranje()
        {
            txtUnos.Enabled = true;
            RandomRijec = BirajRandomRijec();
            string novi = "";
            for (int i = 0; i < RandomRijec.Length; i++)
            {
                novi += "-"; //randomRijec.Length*2
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

                    if (lblNepoznataRijec.Text == RandomRijec && BrojacPokusaja < 5)
                    {
                        lblPoruka.Text = "Bravo!!!";
                        txtUnos.Enabled = false;
                        txtUnos.BackColor = Color.LimeGreen;
                        BrojacPokusaja = 0;
                        btnPotvrdi.Enabled = false;
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
           //treba li mi ono if sender is Button?
           ++BrojacPokusaja;
           lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
           lblPoruka.Text = "";
          
           if (BrojacPokusaja < 5) 
           {
               txtUnos.BackColor = Color.White;
               txtUnos.Enabled = true;
           }
                    
           if (!string.IsNullOrWhiteSpace(txtUnos.Text)) //txtUnos.Text!=""
           {
               if(!JeLiPogodjenaRijec() && !JeLiPogodjenoSlovo())
               {
                   txtUnos.Text = "";
               }
               if (JeLiPogodjenaRijec())
               {
                   lblPoruka.Text = "Bravo! Pogodili ste trazenu rijec!";                      
               }
           }
           if (BrojacPokusaja == 5)
           {
                OnemoguciUnos();
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
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            BrojacPokusaja = 0;
            lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
            txtUnos.Text = "";
            txtUnos.BackColor = Color.White;
            btnPotvrdi.Enabled = true;
            Igranje();
        }    
    }
}
