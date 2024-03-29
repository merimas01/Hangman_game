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
    public partial class frmInfo : Form
    {
        private string lvl;
        public frmInfo(string level="")
        {
            InitializeComponent();
            lvl = level;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            if (frmIgraj.brojKlikanja % 2 != 0)
            {
                this.BackColor = Color.DarkSlateGray;
                lblPravila.ForeColor = Color.White;
                lblNaslov.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.SeaShell;
                lblPravila.ForeColor = Color.Black;
                lblNaslov.ForeColor = Color.Black;
            }
            UcitajInformacije();
        }

        private void UcitajInformacije()
        {
            Text = "Informacije";
            if (lvl == "easy")
            {
                lblPravila.Text = "Imate 5 dozvoljenih puta da pogriješite." + Environment.NewLine +
                    "Koristite i naše dijakritičke znakove (č,ć,ž,đ,š)."+Environment.NewLine+
                    "Možete koristiti mala ili velika slova pri unosu riječi. "+Environment.NewLine+
                    "Klikom na Pomoć možete da dobijete pomoćno slovo ukoliko imate manji broj pogođenih slova od nepogođenih." + Environment.NewLine +
                    "Klikom na Nova riječ dobijate sljedeću riječ za pogađanje. " + Environment.NewLine +
                    "Klikom na Uspjeh, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine + Environment.NewLine +
                    "BODOVANJE: " + Environment.NewLine +
                    "Ako osvojite 30+ bodova, moći ćete pristupiti opciji " + Environment.NewLine +
                    ">>LATINSKE IZREKE<< u kojoj ćete imati priliku pokušati pogoditi nekolike izreke. Bodovanje se " + Environment.NewLine +
                    "nastavlja i za svaku pogođenu izreku dobijate određeni broj bodova." + Environment.NewLine +
                    "Ako osvojite 40+ bodova, moći ćete pristupiti opciji" + Environment.NewLine +
                    ">>IZAZOVI SE<< gdje ćete imati 60 sekundi da pogodite riječ." + Environment.NewLine + Environment.NewLine +
                    "NAPOMENA: "+
                    "Gubite po 3 boda za svako pomoćno slovo. Ako imate manje od 3 ostvarena boda, NE MOŽETE KORISTITI pomoćno slovo." + Environment.NewLine + Environment.NewLine +
                    "PRINCIP BODOVANJA: " + Environment.NewLine +
                    "Broj grešaka: 0 -> Bodovi: 10" + Environment.NewLine +
                    "Broj grešaka: 1 -> Bodovi: 8" + Environment.NewLine +
                    "Broj grešaka: 2 -> Bodovi: 6" + Environment.NewLine +
                    "Broj grešaka: 3 -> Bodovi: 4" + Environment.NewLine +
                    "Broj grešaka: 4 -> Bodovi: 2" + Environment.NewLine +
                    "Bodove dobivate ukoliko pogodite/upišete ispravno datu riječ/izreku." + Environment.NewLine + Environment.NewLine +
                    "Pritiskom na X (cancel) Vaš trenutni uspjeh se poništava."+Environment.NewLine+Environment.NewLine+
                    "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                    "SRETNO!";
            }
            else if (lvl == "hard")
            {
                lblPravila.Text = "Imate 4 dozvoljena puta da pogriješite." + Environment.NewLine +
                    "Koristite i naše dijakritičke znakove (č,ć,ž,đ,š)." + Environment.NewLine +
                    "Možete koristiti mala ili velika slova pri unosu riječi. " + Environment.NewLine +
                    "Klikom na Pomoć možete da dobijete pomoćno slovo ukoliko imate manji broj pogođenih slova od nepogođenih." + Environment.NewLine +
                    "Klikom na Nova riječ dobijate sljedeću riječ za pogađanje. " + Environment.NewLine +
                    "Klikom na Uspjeh, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine + Environment.NewLine +
                    "BODOVANJE:" + Environment.NewLine +
                    "Ako osvojite 25+ bodova, moći ćete pristupiti opciji " + Environment.NewLine +
                    ">>LATINSKE IZREKE<< u kojoj ćete imati priliku pokušati pogoditi nekolike izreke. Bodovanje se " + Environment.NewLine +
                    "nastavlja i za svaku pogođenu izreku dobijate određeni broj bodova." + Environment.NewLine +
                    "Ako osvojite 35+ bodova, moći ćete pristupiti opciji" + Environment.NewLine +
                    ">>IZAZOVI SE<< gdje ćete imati 60 sekundi da pogodite riječ." + Environment.NewLine + Environment.NewLine +
                    "NAPOMENA: "+
                    "Gubite po 3 boda za svako pomoćno slovo. Ako imate manje od 3 ostvarena boda, NE MOŽETE KORISTITI pomoćno slovo." + Environment.NewLine + Environment.NewLine +
                    "PRINCIP BODOVANJA: " + Environment.NewLine +
                    "Broj grešaka: 0 -> Bodovi: 15" + Environment.NewLine +
                    "Broj grešaka: 1 -> Bodovi: 12" + Environment.NewLine +
                    "Broj grešaka: 2 -> Bodovi: 9" + Environment.NewLine +
                    "Broj grešaka: 3 -> Bodovi: 6" + Environment.NewLine +
                    "Bodove dobivate ukoliko pogodite/upišete ispravno datu riječ/izreku." + Environment.NewLine + Environment.NewLine +
                    "Pritiskom na X (cancel) Vaš trenutni uspjeh se poništava." + Environment.NewLine + Environment.NewLine +
                    "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                    "SRETNO!";
            }
            else if (lvl == "adv")
            {
                lblPravila.Text = "Imate 3 dozvoljena puta da pogriješite." + Environment.NewLine +
                       "Koristite i naše dijakritičke znakove (č,ć,ž,đ,š)." + Environment.NewLine +
                       "Možete koristiti mala ili velika slova pri unosu riječi. " + Environment.NewLine +
                       "Klikom na Pomoć možete da dobijete pomoćno slovo ukoliko imate manji broj pogođenih slova od nepogođenih." + Environment.NewLine +
                       "Klikom na Nova riječ dobijate sljedeću riječ za pogađanje. " + Environment.NewLine +
                       "Klikom na Uspjeh, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine + Environment.NewLine +
                       "BODOVANJE: " + Environment.NewLine +
                       "Ako osvojite 20+ bodova, moći ćete pristupiti opciji " + Environment.NewLine +
                       ">>LATINSKE IZREKE<< u kojoj ćete imati priliku pokušati pogoditi nekolike izreke. Bodovanje se " + Environment.NewLine +
                       "nastavlja i za svaku pogođenu izreku dobijate određeni broj bodova." + Environment.NewLine +
                       "Ako osvojite 30+ bodova, moći ćete pristupiti opciji" + Environment.NewLine +
                       ">>IZAZOVI SE<< gdje ćete imati 60 sekundi da pogodite riječ." + Environment.NewLine + Environment.NewLine +
                       "NAPOMENA: " +
                       "Gubite po 3 boda za svako pomoćno slovo. Ako imate manje od 3 ostvarena boda, NE MOŽETE KORISTITI pomoćno slovo." + Environment.NewLine + Environment.NewLine +
                       "PRINCIP BODOVANJA: " + Environment.NewLine +
                       "Broj grešaka: 0 -> Bodovi: 20" + Environment.NewLine +
                       "Broj grešaka: 1 -> Bodovi: 15" + Environment.NewLine +
                       "Broj grešaka: 2 -> Bodovi: 10" + Environment.NewLine +
                       "Bodove dobivate ukoliko pogodite/upišete ispravno datu riječ/izreku." + Environment.NewLine + Environment.NewLine +
                       "Pritiskom na X (cancel) Vaš trenutni uspjeh se poništava." + Environment.NewLine + Environment.NewLine +
                       "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                       "SRETNO!";
            }
        }
    }
}
