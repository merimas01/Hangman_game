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
            UcitajInformacije();
        }

        private void UcitajInformacije()
        {
            if (lvl == "easy")
            {
                lblPravila.Text = "Imate 5 dozvoljenih puta da pogriješite." + Environment.NewLine +
                    "Klikom na Help možete da dobijete pomoćno slovo (imate 5 šansi za to)." + Environment.NewLine +
                    "Klikom na Nova igra započinjete novu igru. " + Environment.NewLine +
                    "Klikom na Score, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine +
                    "BODOVANJE: Ako ostvarite 20 i više bodova, dobijate dodatnih 10 bodova." + Environment.NewLine +
                    "Ako osvojite 30 bodova i više na levelu EASY, moći ćete pristupiti opciji " + Environment.NewLine+
                    ">>TRY SENTENCES<< u kojoj ćete imati priliku pokušati pogoditi nekolike rečenice. Bodovanje se " + Environment.NewLine+
                    "nastavlja i za svaku pogođenu rečenicu dobijate određeni broj bodova."+ Environment.NewLine +
                    "Ako osvojite 40 bodova i više na levelu EASY, moći ćete pristupiti opciji" + Environment.NewLine +
                    ">>CHALLENGE YOURSELF<< gdje ćete imati 60 sekundi da pogodite riječ" +Environment.NewLine+
                    "NAPOMENA: Bodovi Vam se neće smanjiti ukoliko ste koristili pomoćno slovo :)" + Environment.NewLine + Environment.NewLine +
                    "PRINCIP BODOVANJA: " + Environment.NewLine+ 
                    "Broj grešaka: 0 -> Bodovi: 10" + Environment.NewLine +
                    "Broj grešaka: 1 -> Bodovi: 8" + Environment.NewLine +
                    "Broj grešaka: 2 -> Bodovi: 6" + Environment.NewLine +
                    "Broj grešaka: 3 -> Bodovi: 4" + Environment.NewLine +
                    "Broj grešaka: 4 -> Bodovi: 2" + Environment.NewLine +
                    "Bodove dobivate ukoliko pogodite datu riječ/rečenicu." + Environment.NewLine + Environment.NewLine +
                    "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                    "SRETNO!";
            }
            else if (lvl == "hard")
            {
                lblPravila.Text = "Imate 4 dozvoljena puta da pogriješite." + Environment.NewLine +
                    "Klikom na Help možete da dobijete pomoćno slovo (imate 5 šansi za to)." + Environment.NewLine +
                    "Klikom na Nova igra započinjete novu igru. " + Environment.NewLine +
                    "Klikom na Score, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine+
                    "BODOVANJE: Ako ostvarite 20 i više bodova, dobijate dodatnih 10 bodova." + Environment.NewLine+
                    "Ako osvojite 25 bodova i više na levelu HARD, moći ćete pristupiti opciji " + Environment.NewLine +
                    ">>TRY SENTENCES<< u kojoj ćete imati priliku pokušati pogoditi nekolike rečenice. Bodovanje se " + Environment.NewLine +
                    "nastavlja i za svaku pogođenu rečenicu dobijate određeni broj bodova." + Environment.NewLine +
                    "Ako osvojite 35 bodova i više na levelu HARD, moći ćete pristupiti opciji" + Environment.NewLine +
                    ">>CHALLENGE YOURSELF<< gdje ćete imati 60 sekundi da pogodite riječ i 4 puta da pogriješite." + Environment.NewLine +
                    "NAPOMENA: Bodovi Vam se neće smanjiti ukoliko ste koristili pomoćno slovo :)" + Environment.NewLine + Environment.NewLine +
                     "PRINCIP BODOVANJA: " + Environment.NewLine +
                    "Broj grešaka: 0 -> Bodovi: 15" + Environment.NewLine +
                    "Broj grešaka: 1 -> Bodovi: 12" + Environment.NewLine +
                    "Broj grešaka: 2 -> Bodovi: 9" + Environment.NewLine +
                    "Broj grešaka: 3 -> Bodovi: 6" + Environment.NewLine +
                    "Bodove dobivate ukoliko pogodite datu riječ/rečenicu." + Environment.NewLine + Environment.NewLine +
                    "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                    "SRETNO!"; 
            }
            else if (lvl == "adv")
            {
                lblPravila.Text = "Imate 3 dozvoljena puta da pogriješite." + Environment.NewLine +
                       "Klikom na Help možete da dobijete pomoćno slovo (imate 5 šansi za to)." + Environment.NewLine +
                       "Klikom na Nova igra započinjete novu igru. " + Environment.NewLine +
                       "Klikom na Score, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine +
                       "BODOVANJE: Ako ostvarite 20 i više bodova, dobijate dodatnih 10 bodova." + Environment.NewLine +
                       "Ako osvojite 20 bodova i više na levelu ADVANCED, moći ćete pristupiti opciji " + Environment.NewLine +
                       ">>TRY SENTENCES<< u kojoj ćete imati priliku pokušati pogoditi nekolike rečenice. Bodovanje se " + Environment.NewLine +
                       "nastavlja i za svaku pogođenu rečenicu dobijate određeni broj bodova." + Environment.NewLine +
                       "Ako osvojite 30 bodova i više na levelu ADVANCED, moći ćete pristupiti opciji" + Environment.NewLine +
                       ">>CHALLENGE YOURSELF<< gdje ćete imati 60 sekundi da pogodite riječ i 3 puta da pogriješite." + Environment.NewLine +
                       "NAPOMENA: Bodovi Vam se neće smanjiti ukoliko ste koristili pomoćno slovo :)" + Environment.NewLine + Environment.NewLine +
                       "PRINCIP BODOVANJA: " + Environment.NewLine +
                       "Broj grešaka: 0 -> Bodovi: 20" + Environment.NewLine +
                       "Broj grešaka: 1 -> Bodovi: 15" + Environment.NewLine +
                       "Broj grešaka: 2 -> Bodovi: 10" + Environment.NewLine + 
                       "Bodove dobivate ukoliko pogodite datu riječ/rečenicu." + Environment.NewLine + Environment.NewLine +
                       "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                       "SRETNO!"; 
            }
            else if (lvl == "")
            {
                lblPravila.Text = "Ako je dužina riječi manja od 10 broj dozvoljenih puta da pogriješite" + 
                    "je 5, u suprotnom je 3." + Environment.NewLine +
                       "Klikom na Help možete da dobijete pomoćno slovo (imate 5 šansi za to)." + Environment.NewLine +
                       "Klikom na Nova igra započinjete novu igru. " + Environment.NewLine +
                       "Klikom na Score, pokazat će Vam se Vaš trenutni uspjeh." + Environment.NewLine +
                       "VAŽNO: U ovom levelu NEMA BODOVANJA, pa tako ni nemate šanse da pristupite opciji Challenge yourself." + Environment.NewLine + Environment.NewLine +
                       "Igranje možete prekinuti kada god želite." + Environment.NewLine + Environment.NewLine +
                       "SRETNO!";
            }
        }
    }
}
