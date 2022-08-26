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
            Suma = 0;
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
        }
        public static int Suma = 0;
        public string Level = "";
        public static int BrojacPokusaja = 0; //broj gresaka
        public List<string> Stringovi;
        public string RandomRijec= "";
        public static int BrojPobjeda = 0;
        public static int BrojacNovaIgra = 0;
        public int BrojacHelp = 0;
        private int ticks = 0;
        private bool buttonSentencesClicked = false;
        private bool buttonChallengingClicked = false;
        private List<string> PogodjeneRijeci = new List<string>();
        public static int brojKlikanja = 0; //btnMode

        private void StringoviAdvanced()
        {
            Stringovi = new List<string>() { "AUTOREFERENCIJALNOST", "NEKONVENCIJALNOST", "SUVERENITET", "NEZAINTERESIRANOST", "PLUSKVAMPERFEKT", "ZLOUPOTRIJEBITI", "DISKVALIFIKOVATI" };
        }
        private void StringoviEasy()
        {
            Stringovi = new List<string>() { "ISKRENOST", "KOCKA", "MANA", "OSTRVO", "PRIORITET", "TELEVIZOR", "HETEROGEN", "OGRLICA", "IGRICA", "MOBITEL", "SLIKA", "ZAVJESA" };
        }
        private void StringoviHard()
        {
            Stringovi = new List<string>() { "AUTOGENERISATI", "ŠARM", "STIH", "MINIMALIZAM","PURPURNO", "MIMIKRIJA", "LAŽ", "ATAVIZAM", "RATIFIKOVATI", "PALINDROM","PLEONAZAM" };
        }
        string BirajRandomRijec()
        {
            var random = new Random();
            int i = random.Next(Stringovi.Count);

            if (PogodjeneRijeci.Contains(Stringovi[i]))
            {
                int x = 0;
                for (int j = 0; j < Stringovi.Count; j++)
                {
                    if (PogodjeneRijeci.Contains(Stringovi[j]))
                        x++;
                }

                if (x == Stringovi.Count)
                    return "";
                else
                {
                    for (int j = 0; j < Stringovi.Count; j++)
                    {
                        if (!PogodjeneRijeci.Contains(Stringovi[j]))
                            return Stringovi[j];
                    }
                }
            }
           
            return Stringovi[i];        
        }
        public void Igranje()
        {
            RandomRijec = BirajRandomRijec();

            if (RandomRijec == "")
            {
                OnemoguciUnos();
                lblPoruka.Text = "Žao nam je... nemamo novih riječi...";
            }
            else
                Resetuj();

            string novi = "";
            for (int i = 0; i < RandomRijec.Length; i++)
            {
                if (RandomRijec[i] != ' ' && RandomRijec[i]!=',')
                    novi += "_ ";
                else if (RandomRijec[i] == ' ')
                    novi += "  ";
                else if (RandomRijec[i] == ',')
                    novi += ", ";
            }
            lblNepoznataRijec.Text = novi;
      
            lblBrojSlova.Text = RandomRijec.Length.ToString();

            if (buttonChallengingClicked == true && RandomRijec != "")
            {
                ticks = 0;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
                timer1.Enabled = false;

            if (buttonSentencesClicked == false)
            {
                lblBrojSlovaText.Show();
                lblBrojSlova.Show();
            }
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
                PogodjeneRijeci.Add(RandomRijec);              
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
                PogodjeneRijeci.Add(RandomRijec);               
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

            OmoguciBtnHelp();

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
            txtUnos.Enabled = false;
            lblPoruka.Text = "Pokušajte ponovo klikom na >>nova riječ<< !";
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
            btnPotvrdi.Enabled = true;
            lblHelp.Text = "";
            BrojacHelp = 0;
            btnHelp.Enabled = false;
            lblBrojacHint.Text = "";
            pogodjenaSlova = 0;    //ako covjek nikada ne pritisne na btnHelp, ovde se ove varijable moraju osvjeziti
            nepogodjenaSlova = 0;
        }
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            if (RandomRijec != "")
            {
                BrojacNovaIgra++;
            }
            if (lblTimer.Text != "OFF")
            {
                ticks = 0;
                timer1.Start();
            }      
            Resetuj();
            Igranje();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            new frmRezultat().ShowDialog();
        }

        private int pogodjenaSlova = 0;
        private int nepogodjenaSlova = 0;
        private void OmoguciBtnHelp()
        {
            int k = 0;
            for (int i = 0; i < lblNepoznataRijec.Text.Length; i+=2)
            {
                if (lblNepoznataRijec.Text[i] == RandomRijec[k] && lblNepoznataRijec.Text[i]!=' ' && lblNepoznataRijec.Text[i]!=',')
                    pogodjenaSlova++;
                else
                    nepogodjenaSlova++;
                k++;
            }

            if ((RandomRijec.Length >= 10 && BrojacHelp < 3) || (RandomRijec.Length >= 6 && RandomRijec.Length < 10 && BrojacHelp < 2))
            {
                if ((nepogodjenaSlova >= 4 && pogodjenaSlova >= 3))
                    btnHelp.Enabled = true;
            }
            pogodjenaSlova = 0;
            nepogodjenaSlova = 0;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            BrojacHelp++;
            lblBrojacHint.Text = BrojacHelp.ToString();

            var slovo = RandomSlovo().ToString().ToUpper();

            lblHelp.Text = $"Probajte sa slovom: {slovo}";
             
            btnHelp.Enabled = false;
        }
        private char RandomSlovo()
        {
            int i = new Random().Next(RandomRijec.Count());
            while(RandomRijec[i]==' ' || RandomRijec[i] == ',')
            {
                i = new Random().Next(RandomRijec.Count());
            }

            while (lblNepoznataRijec.Text.Contains(RandomRijec[i])) //da li ce ovo ikada biti beskonacna petlja? nece. (jer da bi mogli dobiti pomocno slovo, minimalno 4 prazna mjesta moraju biti. ako su 3 prazna mjesta, btnHelp ce biti onemogucen te samim tim necemo moci koristiti ovu funkciju za generisanje RandomSlova)
            {
                i = new Random().Next(RandomRijec.Count());
            }
            return RandomRijec[i];
        }

        private void frmIgraj_Load(object sender, EventArgs e)
        {
            Igranje();

            if (Level == "adv")
                Text = "Level: Teško";
            else if (Level == "hard")
                Text = "Level: Malo teže";
            else if (Level == "easy")
                Text = "Level: Lagano";
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

            if (Suma >= 20 && Suma <= 39 && buttonSentencesClicked == false && buttonChallengingClicked == false)
                Suma += 5;

            lblBodovi.Text = Suma.ToString();
        }
        private void EnablebtnChallenging()
        {          
            switch (Level)
            {
                case "easy": if (Suma >= 40) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; } break;
                case "hard": if (Suma >= 35) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; } break;
                case "adv":  if (Suma >= 30) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; } break;
            }
        }
        private void EnablebtnSentences()
        {
            switch (Level)
            {
                case "easy": if (Suma >= 30) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; } break;
                case "hard": if (Suma >= 25) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; } break;
                case "adv":  if (Suma >= 20) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; } break;
            }
        }
        private void btnChallenging_Click(object sender, EventArgs e)
        {
            buttonChallengingClicked = true;
            Resetuj();
            if(RandomRijec != "")
               ++BrojacNovaIgra;
            switch (Level)
            {
                case "easy": Stringovi = new List<string>() { "STOLICA", "ZEMLJA", "ISKRENOST", "STATUS", "BAJKA", "MUDROST" }; break;
                case "hard": Stringovi = new List<string>() { "TEHNOLOGIJA", "ORANGUTAN", "MINIJATURAN", "SLIKOVITA","BIOSFERA","RENESANSA" }; break;
                case "adv":  Stringovi = new List<string>() { "ADMINISTRATIVAN", "FILANTROPIJA", "HERMAFRODITIZAM", "HIDRATIZACIJA","INSTRUKCIJA" }; break;
            }
            btnSentences.Enabled = true;
            buttonSentencesClicked = false;
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/riječ:";       
            btnChallenging.Enabled = false; 
            btnNazad.Enabled = true;         
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
            EnablebtnChallenging();
            buttonChallengingClicked = false;
            lblTimer.Text = "OFF";
            Resetuj();
            if(RandomRijec != "")
               ++BrojacNovaIgra;
            switch (Level)
            {
                case "easy": Stringovi = new List<string>() { "DJELA, NE RIJEČI", "KOCKA JE BAČENA", "ISKORISTI DAN", "MLADOST LUDOST", "ISKUSTVO POUČAVA", "IZGLED VARA" }; break;
                case "hard": Stringovi = new List<string>() { "MISLIM, DAKLE JESAM","GRIJEŠITI JE LJUDSKI", "RAD SVE POBJEĐUJE","ISKUSTVO POUČAVA", "UPOZNAJ SEBE SAMOGA", "SREĆA PRATI HRABRE" }; break;
                case "adv": Stringovi = new List<string>() { "DOĐOH, VIDJEH, POBIJEDIH","KLIN SE KLINOM IZBIJA","DOKOLICA RAĐA POROK","BACATI BISERJE PRED SVINJE", "KA ZVIJEZDAMA U VISINE", "DOK DIŠEM, NADAM SE" }; break;
            }      
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/rečenicu:";
            lblBrojSlovaText.Hide();
            lblBrojSlova.Hide();
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

        private void btnMode_Click(object sender, EventArgs e)
        {
            brojKlikanja++;
            if (brojKlikanja % 2 != 0)
            {
                btnMode.Text = "DARK";
                this.BackColor = Color.Black;
                lblPogodiRijec.ForeColor = Color.White;
                lblUkucaj.ForeColor = Color.White;
                lblPokusaj.ForeColor = Color.White;
                lblNepoznataRijec.ForeColor = Color.White;
                lblBrojSlova.ForeColor = Color.White;
                lblBrojSlovaText.ForeColor = Color.White;
                lblBodoviText.ForeColor = Color.White;
                lblBodoviText.ForeColor = Color.White;
                lblBodovi.ForeColor = Color.White;
                lblBrojacPokusaja.ForeColor = Color.White;
                lblTimerText.ForeColor = Color.White;
                lblHelp.ForeColor = Color.White;
                lblBrojacHint.ForeColor = Color.White;
                txtUnos.ForeColor = Color.White;
                txtUnos.BackColor = Color.Black;
            }
            else
            {
                btnMode.Text = "LIGHT";
                this.BackColor = Color.SeaShell;
                lblPogodiRijec.ForeColor = Color.Black;
                lblUkucaj.ForeColor = Color.Black;
                lblPokusaj.ForeColor = Color.Black;
                lblNepoznataRijec.ForeColor = Color.Black;
                lblBrojSlova.ForeColor = Color.Black;
                lblBrojSlovaText.ForeColor = Color.Black;
                lblBodoviText.ForeColor = Color.Black;
                lblBodoviText.ForeColor = Color.Black;
                lblBodovi.ForeColor = Color.Black;
                lblBrojacPokusaja.ForeColor = Color.Black;
                lblTimerText.ForeColor = Color.Black;
                lblHelp.ForeColor = Color.Black;
                lblBrojacHint.ForeColor = Color.Black;
                txtUnos.ForeColor = Color.Black;
                txtUnos.BackColor = Color.White;
            }
        }
    }
}
