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
        public frmIgraj(string level = "")
        {
            InitializeComponent();
            BrojacNovaIgra += 1; //kada se pokrece inicijalna igra
            Level = level;
            Resetuj();
            ticks = 0;
            if (level == "easy")
            {
                StringoviEasy();
            }
            else if (level == "hard")
            {
                StringoviHard();
            }
            else if (level == "adv")
            {
                StringoviAdvanced();
            }   
            else if (level == "")
            {
                StringoviRandom();
            }         
        }
        public static int Suma { get; set; } = 0;
        public string Level { get; set; } = "";
        public static int BrojacPokusaja { get; set; } = 0; //broj gresaka
        public List<string> Stringovi { get; set; }
        public string RandomRijec { get; set; } = "";
        public static int BrojPobjeda { get; set; } = 0;
        public static int BrojacNovaIgra { get; set; } = 0;
        public int BrojacHelp { get; set; } = 0;
        private int ticks=0;
        private bool buttonSentencesClicked = false;
        private bool buttonChallengingClicked = false;

        private void StringoviAdvanced()
        {
            Stringovi = new List<string>() { "AUTOREFERENCIJALNOST", "NEKONVENCIJALNOST", "NEZAINTERESIRANOST", "PLUSKVAMPERFEKT", "ZLOUPOTRIJEBITI", "DISKVALIFIKOVATI" };
        }
        private void StringoviEasy()
        {
            Stringovi = new List<string>() { "KOCKA", "TELEVIZOR", "OGRLICA", "IGRICA", "MOBITEL", "SLIKA", "ZAVJESA" };
        }
        private void StringoviHard()
        {
            Stringovi = new List<string>() { "AUTOGENERISATI", "PURPURNO", "MIMIKRIJA", "ATAVIZAM", "RATIFIKOVATI", "PALINDROM" };
        }
        private void StringoviRandom()
        {
            Stringovi = new List<string>() { "PURPURNO", "KOCKA", "MIMIKRIJA", "NEKONVENCIJALNOST", "PALINDROM", "OMEĐITI", "DISKVALIFIKOVATI" };
        }
        string BirajRandomRijec()
        {
            var random = new Random();
            int i = random.Next(Stringovi.Count);
            while (Stringovi[i] == RandomRijec) //da se ne ponavlja dva puta ista RandomRijec
            {
                i = random.Next(Stringovi.Count);
            }
            return Stringovi[i];        
        }
        public void Igranje()
        {
            RandomRijec = BirajRandomRijec();
            string novi = "";
            for (int i = 0; i < RandomRijec.Length; i++)
            {
                if (RandomRijec[i] != ' ')
                    novi += "_ ";
                else
                    novi += "  ";
            }
            lblNepoznataRijec.Text = novi;
      
            lblBrojSlova.Text = RandomRijec.Length.ToString();

            if (buttonChallengingClicked == true)//btnChallenging.Enabled == true
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
                timer1.Enabled = false;
        }
        bool JeLiPogodjenoSlovo()
        {
            bool valid = false;
            
            if (txtUnos.Text.Length == 1) //ako je ukucao samo jedno slovo
            {
                for (int i = 0; i < RandomRijec.Length; i++)
                {
                    if (txtUnos.Text.ToUpper()[0] == RandomRijec[i]) //string moze biti samo jedno slovo, tako da kada bi to slovo poredili sa charom, morali bi izvuc slovo iz stringa u smislu: s[0]
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
            lblHelp.Text = "";

            if (string.IsNullOrWhiteSpace(txtUnos.Text))
            {
                DialogResult result = MessageBox.Show("Niste ništa napisali... Jeste li sigurni da želite potvrditi unos?", "Potvrdi unos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    ++BrojacPokusaja;
                    lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                }
            }
                 
            if (!string.IsNullOrWhiteSpace(txtUnos.Text))
            {
                if ((txtUnos.Text.Length==1 && lblNepoznataRijec.Text.Contains(txtUnos.Text.ToUpper().ToString())) 
                    || (!JeLiPogodjenaRijec() && !JeLiPogodjenoSlovo()))
                {
                    txtUnos.Text = "";
                    ++BrojacPokusaja;
                    lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
                } 
                if (JeLiPogodjenoSlovo())
                {
                    txtUnos.Text = "";
                }
                if (JeLiPogodjenaRijec())  
                {
                    lblPoruka.Text = "Bravo! Pogodili ste traženu riječ!";
                    BrojPobjeda++;
                    Bodovi();
                    if(buttonSentencesClicked==false)
                        EnablebtnSentences();
                    
                    if(buttonChallengingClicked==false)
                        EnablebtnChallenging();
                    else
                    {
                        timer1.Stop();
                        ticks = 0;
                    }                    
                }
            }           
            if (JeLiKraj())
            {
                OnemoguciUnos();
            }   
        }
        private bool JeLiKraj()
        {
            return (Level == "easy" && BrojacPokusaja == 5) || (Level == "hard" && BrojacPokusaja == 4) ||
                (Level == "adv" && BrojacPokusaja == 3) || (Level == "" && RandomRijec.Length < 10 && BrojacPokusaja == 5)
                || (Level == "" && RandomRijec.Length >= 10 && BrojacPokusaja == 3);
        }
        private void OnemoguciUnos()
        {
            txtUnos.BackColor = Color.Beige;
            txtUnos.Enabled = false;
            lblPoruka.Text = "Pokušajte ponovo klikom na >>nova igra<< !";
            lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
            btnPotvrdi.Enabled = false;
            btnHelp.Enabled = false;
            if (buttonChallengingClicked == true)
            {
                timer1.Stop();
                ticks = 0;
            }
        }
        private void Resetuj()
        {
            BrojacPokusaja = 0;
            lblBrojacPokusaja.Text = $"{BrojacPokusaja}";
            lblPoruka.Text = "";
            txtUnos.Enabled = true;       
            txtUnos.Text = "";
            txtUnos.BackColor = Color.White;
            btnPotvrdi.Enabled = true;
            lblHelp.Text = "";
            BrojacHelp = 0;
            btnHelp.Enabled = true;
            lblBrojacHint.Text = "";
        }
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            BrojacNovaIgra++;
            if (lblTimer.Text != "OFF")
            {
                ticks = 0;
                timer1.Start();
            }
            //btnSentences.Enabled = false;
            //btnChallenging.Enabled = false;        
            Resetuj();
            Igranje();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            new frmRezultat().ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {        
            BrojacHelp++;
            lblBrojacHint.Text = BrojacHelp.ToString();

            var slovo = RandomSlovo().ToString().ToUpper();
            if(RandomRijec.Contains(slovo) && !lblNepoznataRijec.Text.Contains(slovo))
            {
                lblHelp.Text = $"Probajte sa slovom: {slovo}";
            }
            else
            {
                lblHelp.Text = "Hint nije dostupan";
            }
            if (BrojacHelp > 5)
            {
                btnHelp.Enabled = false;
                lblHelp.Text = "Vaših 5 šansi ste iskoristili :/";
            }            
        }
        private char RandomSlovo()
        {
            var slova = "abcdefghijklmnoprstuvz";
            var s = new Random().Next(slova.Count());
            return slova[s];
        }

        private void frmIgraj_Load(object sender, EventArgs e)
        {
            Igranje();

            if (Level != "adv" && Level!="")
                Text = $"Level: {Level}";
            else if (Level == "adv")
                Text = "Level: advanced";
            else if (Level == "")
                Text = "Level: random";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new frmInfo(Level).Show();
        }
        private void Bodovi()
        {       
            if (Level == "easy")
            {
                if (BrojacPokusaja == 0)
                    Suma += 10;
                else if (BrojacPokusaja == 1)
                    Suma += 8;
                else if (BrojacPokusaja == 2)
                    Suma += 6;
                else if (BrojacPokusaja == 3)
                    Suma += 4;
                else if (BrojacPokusaja == 4)
                    Suma += 2;
            }
            else if (Level == "hard")
            {
                if (BrojacPokusaja == 0)
                    Suma += 15;
                else if (BrojacPokusaja == 1)
                    Suma += 12;
                else if (BrojacPokusaja == 2)
                    Suma += 9;
                else if (BrojacPokusaja == 3)
                    Suma += 6;
            }
            else if (Level == "adv")
            {
                if (BrojacPokusaja == 0)
                    Suma += 20;
                else if (BrojacPokusaja == 1)
                    Suma += 15;
                else if (BrojacPokusaja == 2)
                    Suma += 10;
            }

            if(Suma>=20 && Suma<=39 && buttonSentencesClicked == false && buttonChallengingClicked==false) //provjeriti, trebalo bi da samo jednom poveca vrijednost
                Suma += 10;
            lblBodovi.Text = Suma.ToString();       
        }
        private void EnablebtnChallenging()
        {
            switch (Level)
            {
                case "easy": if (Suma >= 40) btnChallenging.Enabled = true; break;
                case "hard": if (Suma >= 35) btnChallenging.Enabled = true; break;
                case "adv":  if (Suma >= 30) btnChallenging.Enabled = true; break;
            }
        }
        private void EnablebtnSentences()
        {
            switch (Level)
            {
                case "easy": if (Suma >= 30) btnSentences.Enabled = true; break;
                case "hard": if (Suma >= 25) btnSentences.Enabled = true; break;
                case "adv":  if (Suma >= 20) btnSentences.Enabled = true; break;
            }
        }
        private void btnChallenging_Click(object sender, EventArgs e)
        {
            buttonChallengingClicked = true;
            Resetuj();
            BrojacNovaIgra++;
            switch (Level)
            {
                case "easy": Stringovi = new List<string>() { "STOLICA", "ZEMLJA", "ISKRENOST", "STATUS" }; break;
                case "hard": Stringovi = new List<string>() { "TEHNOLOGIJA", "ORANGUTAN", "MINIJATURAN", "SLIKOVITA","BIOSFERA" }; break;
                case "adv":  Stringovi = new List<string>() { "ADMINISTRATIVAN", "FILANTROPIJA", "HERMAFRODITIZAM", "HIDRATIZACIJA" }; break;
            }         
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/riječ:";
            btnChallenging.Enabled = false; 
            btnNazad.Enabled = true;
            btnSentences.Enabled = true;
            buttonSentencesClicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lblTimer.Text = ticks.ToString();
            if (ticks == 60)
            {
                lblTimer.Text = "Done";
                timer1.Stop();
                txtUnos.Enabled = false;
                btnPotvrdi.Enabled = false;
                btnHelp.Enabled = false;
            }
        }

        private void btnSentences_Click(object sender, EventArgs e)
        {
            buttonSentencesClicked = true;
            btnNazad.Enabled = true;
            buttonChallengingClicked = false;
            lblTimer.Text = "OFF";
            Resetuj();
            BrojacNovaIgra++;
            Stringovi = new List<string>() { "ŽIVOT JE LIJEP", "ISTINSKA RADOST", "STATUS QUO" };
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/rečenicu:";
            btnSentences.Enabled = false;       
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Resetuj();
            EnablebtnSentences();
            EnablebtnChallenging();
            buttonSentencesClicked = false;
            buttonChallengingClicked = false;
            lblTimer.Text = "OFF";
            switch (Level)
            {
                case "easy": StringoviEasy(); break;
                case "hard": StringoviHard(); break;
                case "adv":  StringoviAdvanced(); break;
            }
            Igranje();
            ++BrojacNovaIgra;
            btnNazad.Enabled = false;
        }
    }
}
