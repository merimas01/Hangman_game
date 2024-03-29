﻿using System;
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
        public static List<string> Stringovi;
        public string RandomRijec= "";
        public static int BrojPobjeda = 0;
        public static int BrojacNovaIgra = 0;
        public int BrojacHelp = 0;
        private int ticks = 0;
        private bool buttonSentencesClicked = false;                 
        private bool buttonChallengingClicked = false;
        public static int brojKlikanja = 0; //btnMode
        private int TrenutnoPredjenihRijeci = 0;  //iz pocetnog levela
        private int brojacLatinskeIzreke = 0;
        private int brojacIzazoviSe = 0;
        private List<string> IskoristeneRijeci = new List<string>();
        public static int ukupnoRijeciLatinskeIzreke = 0;
        public static int ukupnoRijeciIzazoviSe = 0;
        public static int ukupnoRijeciPocetna = 0;

        private void StringoviAdvanced()
        {
            Stringovi = new List<string>() { "AUTOREFERENCIJALNOST", "NEKONVENCIONALNOST", "SUVERENITET", "NEZAINTERESIRANOST", "PLUSKVAMPERFEKT", "ZLOUPOTRIJEBITI", "DISKVALIFIKOVATI" };
            ukupnoRijeciPocetna = Stringovi.Count;
        }
        private void StringoviEasy()
        {
            Stringovi = new List<string>() { "ISKRENOST", "KARNEVAL", "KOCKA", "MANA", "OSTRVO", "PRIORITET", "TELEVIZOR", "HETEROGEN", "OGRLICA", "IGRICA", "MOBITEL", "SLIKA", "ZAVJESA" };
            ukupnoRijeciPocetna = Stringovi.Count;
        }
        private void StringoviHard()
        {
            Stringovi = new List<string>() { "AUTOGENERISATI", "ŠARM", "STIH", "MINIMALIZAM","PURPURNO", "MIMIKRIJA", "LAŽ", "ATAVIZAM", "RATIFIKOVATI", "PALINDROM","PLEONAZAM" };
            ukupnoRijeciPocetna = Stringovi.Count;
        }
        string BirajRandomRijec()
        {
            var random = new Random();
            int i = random.Next(Stringovi.Count);       

            if (IskoristeneRijeci.Contains(Stringovi[i]))
            {
                int x = 0;
                for (int j = 0; j < Stringovi.Count; j++)
                {
                    if (IskoristeneRijeci.Contains(Stringovi[j]))
                        x++;
                }

                if (x == Stringovi.Count)
                    return "";
                else
                {
                    for (int j = 0; j < Stringovi.Count; j++)
                    {
                        if (!IskoristeneRijeci.Contains(Stringovi[j]))
                            return Stringovi[j];
                    }
                }
            }
           
            return Stringovi[i];        
        }

        private void BrojacRijeci()
        {
            if (buttonChallengingClicked == false && buttonSentencesClicked == false)
            {
                TrenutnoPredjenihRijeci++;
               
                if (TrenutnoPredjenihRijeci >= ukupnoRijeciPocetna)
                {
                    lblBrojRijeci.Text = $"{ukupnoRijeciPocetna}/{ukupnoRijeciPocetna}";
                   // btn_prebaci.Enabled = false;
                }
                else
                {
                   // btn_prebaci.Enabled = true;
                    lblBrojRijeci.Text = $"{TrenutnoPredjenihRijeci}/{ukupnoRijeciPocetna}";
                }  
            }

            if (buttonSentencesClicked == true && buttonChallengingClicked == false)
            {
                brojacLatinskeIzreke++;
               
                if (brojacLatinskeIzreke >= ukupnoRijeciLatinskeIzreke)
                {
                    lblBrojRijeci.Text = $"{ukupnoRijeciLatinskeIzreke}/{ukupnoRijeciLatinskeIzreke}";
                    //btn_prebaci.Enabled = false;
                }                   
                else 
                {
                   // btn_prebaci.Enabled = true;
                    lblBrojRijeci.Text = $"{brojacLatinskeIzreke}/{ukupnoRijeciLatinskeIzreke}";
                }                  
            }

            if (buttonChallengingClicked == true && buttonSentencesClicked == false)
            {
                brojacIzazoviSe++;                

                if (brojacIzazoviSe >= ukupnoRijeciIzazoviSe)
                {
                    lblBrojRijeci.Text = $"{ukupnoRijeciIzazoviSe}/{ukupnoRijeciIzazoviSe}";
                   // btn_prebaci.Enabled = false;
                }
                else
                {
                 //   btn_prebaci.Enabled = true;
                    lblBrojRijeci.Text = $"{brojacIzazoviSe}/{ukupnoRijeciIzazoviSe}";
                }                   
            }
        }

        private void EnablanjeDugmadi()
        {
            if (buttonSentencesClicked == true && brojacIzazoviSe < ukupnoRijeciIzazoviSe)
            {
                btnChallenging.Enabled = true;
            }
            if (buttonChallengingClicked == true && brojacLatinskeIzreke < ukupnoRijeciLatinskeIzreke)
            {
                btnSentences.Enabled = true;
            }
            if ((buttonSentencesClicked == true || buttonChallengingClicked == true) &&
                TrenutnoPredjenihRijeci < ukupnoRijeciPocetna)
            {
                btnNazad.Enabled = true;
            }
            if (buttonSentencesClicked == false && buttonChallengingClicked == false && brojacIzazoviSe < ukupnoRijeciIzazoviSe)
            {
                btnChallenging.Enabled = true;
            }
            if (buttonSentencesClicked == false && buttonChallengingClicked == false && brojacLatinskeIzreke < ukupnoRijeciLatinskeIzreke)
            {
                btnSentences.Enabled = true;
            }
        }

        public void Igranje()
        {
            RandomRijec = BirajRandomRijec();

            Resetuj();

            if (RandomRijec == "")
            {
                OnemoguciUnos();
                lblPoruka.Text = "Žao nam je... sve riječi ste iskoristili...";
                EnablanjeDugmadi();
            }
            else
            {
                BrojacNovaIgra++;
                IskoristeneRijeci.Add(RandomRijec);        
            }
               
            BrojacRijeci();
          
            //napravi nepoznatu rijec 

            string novi = "";
            for (int i = 0; i < RandomRijec.Length; i++)
            {
                if (RandomRijec[i] != ' ' && RandomRijec[i] != ',')
                    novi += "_ ";
                else if (RandomRijec[i] == ' ')
                    novi += "  ";
                else if (RandomRijec[i] == ',')
                    novi += ", ";
            }
            lblNepoznataRijec.Text = novi;
           
            lblBrojSlova.Text = RandomRijec.Length.ToString();

            //promjena boje buttona

            if ((Level == "easy" && Suma < 30) || (Level == "hard" && Suma < 25) || (Level == "adv" && Suma < 20))
            {
                btnSentences.BackColor = Color.Gainsboro;
                btnChallenging.BackColor = Color.Gainsboro;
            }
            else if ((Level == "easy" && Suma > 30 && Suma<40) || (Level == "hard" && Suma > 25 && Suma<35) || (Level == "adv" && Suma > 20 && Suma<30))
                btnChallenging.BackColor = Color.Gainsboro;

            //pokreni timer

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

        private void Enablaj_btnNovuIgru_I_btnNazad()
        {
            if (buttonSentencesClicked == false && buttonChallengingClicked == false)
                btnNovaIgra.Enabled = true;
            else if (buttonSentencesClicked == true && ((Level == "easy" && Suma >= 30) || (Level == "hard" && Suma >= 25) || (Level == "adv" && Suma >= 20)))
                btnNovaIgra.Enabled = true;
            else if (buttonChallengingClicked == true && ((Level == "easy" && Suma >= 40) || (Level == "hard" && Suma >= 35) || (Level == "adv" && Suma >= 30)))
                btnNovaIgra.Enabled = true;        
            if ((buttonSentencesClicked == true || buttonChallengingClicked == true) && TrenutnoPredjenihRijeci < ukupnoRijeciPocetna)
                btnNazad.Enabled = true;

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
                //btn_prebaci.Enabled = false;

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
                    lblPoruka.Text = "Bravo! Pogodili ste!";
                    BrojPobjeda++;
                    Bodovi();

                    Enablaj_btnNovuIgru_I_btnNazad();

                    if (buttonSentencesClicked==false)
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
                txtUnos.Text = RandomRijec;
                //btnNovaIgra.Enabled=true;
                
                Enablaj_btnNovuIgru_I_btnNazad();

                if (buttonSentencesClicked == false)
                    EnablebtnSentences();

                if (buttonChallengingClicked == false)
                    EnablebtnChallenging();
            }   
        }
        private bool JeLiKraj()
        {
            return (Level == "easy" && BrojacPokusaja == 5) || (Level == "hard" && BrojacPokusaja == 4) ||
                (Level == "adv" && BrojacPokusaja == 3);
        }
        private void OnemoguciUnos()
        {
            txtUnos.Enabled = false;
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
            btnNovaIgra.Enabled = false;

            btnChallenging.Enabled = false;
            btnSentences.Enabled = false;

            btnNazad.Enabled = false;

            if (lblTimer.Text != "OFF")
            {
                ticks = 0;
                timer1.Start();
            }      

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
            btnHelp.Enabled = false;

            if (Suma >= 3)
            {
                int k = 0;
                if (lblNepoznataRijec.Text.Contains(','))
                {
                    string noviLabel = lblNepoznataRijec.Text.Trim(',');

                    for (int i = 0; i < noviLabel.Length; i += 2)
                    {
                        if (noviLabel[i] == RandomRijec[k] && noviLabel[i] != ' ')
                            pogodjenaSlova++;
                        else
                            nepogodjenaSlova++;
                        k++;
                    }
                }
                else
                {
                    for (int i = 0; i < lblNepoznataRijec.Text.Length; i += 2)
                    {
                        if (lblNepoznataRijec.Text[i] == RandomRijec[k] && lblNepoznataRijec.Text[i] != ' ')
                            pogodjenaSlova++;
                        else
                            nepogodjenaSlova++;
                        k++;
                    }
                }         

                //stari nacin
                //if ((Level == "easy" && BrojacHelp < 2) || (Level == "hard" && BrojacHelp < 3) || (Level == "adv" && BrojacHelp < 3))
                //{
                //    if ((nepogodjenaSlova >= 4 && pogodjenaSlova >= 3))
                //        btnHelp.Enabled = true;
                //}

                if (pogodjenaSlova < nepogodjenaSlova && !JeLiPogodjenaRijec())
                {
                    btnHelp.Enabled = true;
                }

                pogodjenaSlova = 0;
                nepogodjenaSlova = 0;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            BrojacHelp++;
            lblBrojacHint.Text = BrojacHelp.ToString();

            var slovo = RandomSlovo().ToString().ToUpper();

            lblHelp.Text = $"Probajte sa slovom: {slovo}";

            //svako pomocno slovo oduzima 3 boda

            Suma -= 3;

            lblBodovi.Text = Suma.ToString();
             
            btnHelp.Enabled = false;
        }

        private char RandomSlovo()
        {
            int i = new Random().Next(RandomRijec.Count());
            while(RandomRijec[i]==' ' || RandomRijec[i] == ',')
            {
                i = new Random().Next(RandomRijec.Count());
            }

            while (lblNepoznataRijec.Text.Contains(RandomRijec[i])) //da li ce ovo ikada biti beskonacna petlja? nece. 
            {
                i = new Random().Next(RandomRijec.Count());
            }
            return RandomRijec[i];
        }

        private void frmIgraj_Load(object sender, EventArgs e)
        {
            Igranje();

            if (Level == "adv")
            {
                Text = "Level: Teško";
            }          
            else if (Level == "hard")
            {
                Text = "Level: Srednje";
            }               
            else if (Level == "easy")
            {
                Text = "Level: Lagano";
            }

            //if (buttonSentencesClicked == true)
            //    Text += " - Latinske izreke";
            //else if (buttonChallengingClicked == true)
            //    Text += " - Izazovi se";
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

            lblBodovi.Text = Suma.ToString();
        }
        private void EnablebtnChallenging()
        {          
            switch (Level)
            {
                case "easy": 
                    if (Suma >= 40) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; }
                    if (brojacIzazoviSe >= ukupnoRijeciIzazoviSe && ukupnoRijeciIzazoviSe != 0) btnChallenging.Enabled = false;
                    if (Suma < 40) { btnChallenging.BackColor = Color.Gainsboro; btnChallenging.Enabled = false; }
                    break;
                case "hard": 
                    if (Suma >= 35) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; }
                    if (brojacIzazoviSe >= ukupnoRijeciIzazoviSe && ukupnoRijeciIzazoviSe != 0) btnChallenging.Enabled = false;
                    if (Suma < 35) { btnChallenging.BackColor = Color.Gainsboro; btnChallenging.Enabled = false; }
                    break;
                case "adv":  
                    if (Suma >= 30) { btnChallenging.Enabled = true; btnChallenging.BackColor = Color.LimeGreen; }
                    if (brojacIzazoviSe >= ukupnoRijeciIzazoviSe && ukupnoRijeciIzazoviSe != 0) btnChallenging.Enabled = false;
                    if (Suma < 30) { btnChallenging.BackColor = Color.Gainsboro; btnChallenging.Enabled = false; }
                    break;
            }
        }
        private void EnablebtnSentences()
        {
            switch (Level)
            {
                case "easy": 
                    if (Suma >= 30) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; }
                    if (brojacLatinskeIzreke >= ukupnoRijeciLatinskeIzreke && ukupnoRijeciLatinskeIzreke != 0) btnSentences.Enabled = false;
                    if (Suma < 30) { btnSentences.BackColor = Color.Gainsboro; btnSentences.Enabled = false; }
                    break;
                case "hard": 
                    if (Suma >= 25) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; }
                    if (brojacLatinskeIzreke >= ukupnoRijeciLatinskeIzreke && ukupnoRijeciLatinskeIzreke != 0) btnSentences.Enabled = false;
                    if (Suma < 25) { btnSentences.BackColor = Color.Gainsboro; btnSentences.Enabled = false; }
                    break;
                case "adv":  
                    if (Suma >= 20) { btnSentences.Enabled = true; btnSentences.BackColor = Color.Gold; }
                    if (brojacLatinskeIzreke >= ukupnoRijeciLatinskeIzreke && ukupnoRijeciLatinskeIzreke != 0) btnSentences.Enabled = false;
                    if (Suma < 20) { btnSentences.BackColor = Color.Gainsboro; btnSentences.Enabled = false; }
                    break;
            }
        }

        private void btnChallenging_Click(object sender, EventArgs e)
        {
            buttonChallengingClicked = true;

            btnNovaIgra.Enabled = false;

            switch (Level)
            {
                case "easy": Stringovi = new List<string>() { "STOLICA", "ZAPAD", "HUMANOST", "MISLIOC", "STATUS", "BAJKA", "MUDROST" }; ukupnoRijeciIzazoviSe = Stringovi.Count; break;
                case "hard": Stringovi = new List<string>() { "TEHNOLOGIJA", "ORANGUTAN", "MINIJATURAN", "SLIKOVITA","BIOSFERA","RENESANSA" }; ukupnoRijeciIzazoviSe = Stringovi.Count; break;
                case "adv":  Stringovi = new List<string>() { "ADMINISTRATIVAN", "FILANTROPIJA", "HERMAFRODITIZAM", "HIDRATIZACIJA","INSTRUKCIJA" }; ukupnoRijeciIzazoviSe = Stringovi.Count; break;
            }
            // btnSentences.Enabled = true;
            btnSentences.Enabled = false;
            buttonSentencesClicked = false;
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/riječ:";       
            btnChallenging.Enabled = false; 
            btnNazad.Enabled = false;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lblTimer.Text = ticks.ToString();
            if (ticks == 60)
            {
                lblTimer.Text = "Kraj";
                timer1.Stop();
                txtUnos.Enabled = false;
                btnPotvrdi.Enabled = false;
                btnHelp.Enabled = false;
                txtUnos.Text = RandomRijec;
                btnNovaIgra.Enabled = true;
                btnSentences.Enabled = true;
                btnNazad.Enabled = true;
            }
        }

        private void btnSentences_Click(object sender, EventArgs e)
        {
            buttonSentencesClicked = true;

            btnNovaIgra.Enabled = false;

           // EnablebtnChallenging();
            buttonChallengingClicked = false;
            lblTimer.Text = "OFF";

            switch (Level)
            {
                case "easy": Stringovi = new List<string>() { "DJELA, NE RIJEČI", "KOCKA JE BAČENA", "ISKORISTI DAN", "MLADOST LUDOST", "ISKUSTVO POUČAVA", "IZGLED VARA" }; ukupnoRijeciLatinskeIzreke = Stringovi.Count;  break;
                case "hard": Stringovi = new List<string>() { "MISLIM, DAKLE JESAM","GRIJEŠITI JE LJUDSKI", "RAD SVE POBJEĐUJE","ISKUSTVO POUČAVA", "UPOZNAJ SEBE SAMOGA", "SREĆA PRATI HRABRE" }; ukupnoRijeciLatinskeIzreke = Stringovi.Count; break;
                case "adv": Stringovi = new List<string>() { "DOĐOH, VIDJEH, POBIJEDIH","KLIN SE KLINOM IZBIJA","DOKOLICA RAĐA POROK","BACATI BISERJE PRED SVINJE", "KA ZVIJEZDAMA U VISINE", "DOK DIŠEM, NADAM SE" }; ukupnoRijeciLatinskeIzreke = Stringovi.Count; break;
            }      
            Igranje();
            lblUkucaj.Text = "Ukucaj slovo/izreku:";
            lblBrojSlovaText.Hide();
            lblBrojSlova.Hide();
            btnSentences.Enabled = false;
            btnNazad.Enabled = false;
            btnChallenging.Enabled = false;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            //Resetuj();
            //EnablebtnSentences();
            //EnablebtnChallenging();
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
            btnNazad.Enabled = false;
            btnNovaIgra.Enabled = false;
            btnSentences.Enabled = false;
            btnChallenging.Enabled = false;
        }

       
        private void btnMode_Click(object sender, EventArgs e)
        {
            brojKlikanja++;
            if (brojKlikanja % 2 != 0)
            {
                btnMode.Text = "TAMNO";
                this.BackColor = Color.DarkSlateGray;
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
                txtUnos.BackColor = Color.DarkSlateGray;
                lblBrojRijeci.BackColor = Color.White;
                lblBrojRijeci.ForeColor = Color.DarkSlateGray;
            }
            else
            {
                btnMode.Text = "SVIJETLO";
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
                txtUnos.BackColor = Color.SeaShell;
                lblBrojRijeci.BackColor = Color.Gray;
                lblBrojRijeci.ForeColor = Color.White;
            }

        }

        //ovaj btn mozemo i izbrisati (i sve linije koda gdje ga referenciramo)
        private void btn_prebaci_Click(object sender, EventArgs e)
        {
            Igranje();
        }
    }
}
