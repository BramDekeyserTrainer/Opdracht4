using System.Security.Policy;

namespace Opdracht4
{
    public partial class formTeDoen : Form
    {
        /*Ik maak een nieuwe FouteRij aan.
         Deze noem ik 'Taken'.*/
        FouteRij<TeDoen> Taken = new FouteRij<TeDoen>();
        public formTeDoen()
        {
            InitializeComponent();
        }


        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            /*Wanneer de tekst in de knop 'Uit' bevat,
             veranderd de tekst in 'Aan' en de achtergrond kleur in groen.*/
            if (btnMessageBox.Text == "Uit")
            {
                btnMessageBox.Text = "Aan";
                btnMessageBox.BackColor = Color.Green;
            }

            /*Wanneer de tekst in de knop 'Aan' bevat,
             veranderd de tekst in 'Uit' en de achtergrond kleur in rood.*/
            else
            {
                btnMessageBox.Text = "Uit";
                btnMessageBox.BackColor = Color.Red;
            }
        }

        private void btnTekstveld_Click(object sender, EventArgs e)
        {
            /*Wanneer de tekst in de knop 'Uit' bevat,
             veranderd de tekst in 'Aan' en de achtergrond kleur in groen.*/
            if (btnTekstveld.Text == "Uit")
            {
                btnTekstveld.Text = "Aan";
                btnTekstveld.BackColor = Color.Green;
            }
            else
            {
                /*Wanneer de tekst in de knop 'Aan' bevat,
                 veranderd de tekst in 'Uit' en de achtergrond kleur in rood.*/
                btnMessageBox.Text = "Uit";
                btnMessageBox.BackColor = Color.Red;
            }
        }

        /*De methode Volgende() wordt uitgevoerd bij het klikken op de volgende knop.*/
        private void btnTaakVolgende_Click(object sender, EventArgs e)
        {
            Taken.Volgende();
        }

        /*De methode 'Toevoegen()' wordt toegevoegd bij het klikken op de volgende knop.
         Ik geef de tekst van tbTitel en de lijnen inhoud van tbInformatie mee als parameters
        bij de uitvoer van deze functie.
        Hiervoor heb ik de constructor moeten uitbreiden volgens de suggesties van Visual Studio.
        Ikzelf krijg geen foutmelding meer, maar ben ook niet volledig zeker of dit ook werkt zoals het hoort.
        */
        private void btnTaakToevoegen_Click(object sender, EventArgs e)
        {
            Taken.Toevoegen(new TeDoen(tbTitel.Text, tbInformatie.Lines));
        }

        /*De methode 'Verwijderen()' wordt uitgevoerd wanneer op de volgende knop wordt gedrukt.
         Wanneer een taak klaar is, willen we deze namelijk uit de lijst halen.*/
        private void btnTaakAfgewerkt_Click(object sender, EventArgs e)
        {
            Taken.Verwijderen();
        }

        /*De methode 'ZetAchteraan', zet de taak achteraan wanneer er op de volgende knop wordt gedrukt.*/
        private void btnAchteraan_Click(object sender, EventArgs e)
        {
            Taken.ZetAchteraan();
        }
    }
    }
