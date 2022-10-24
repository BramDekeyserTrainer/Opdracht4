using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Opdracht4
{
    internal class TeDoen
    {
        public int teller;
        public int Id;
        public int Volgnummer()
        {
            return Interlocked.Increment(ref Id);
        }

        /*Ik declareer de nodige properties.
         Bij de private DateTime zet ik een getter en een setter.*/
        private DateTime? Tijdstip { get; set; }
        public string Titel;
        public string[] Informatie;
        private string text;
        private string[] lines;


        /*Ik declareer mijn publieke event 'Meedelen'.
         De EventHandler delegate is een voorgedefinieerde delegate.
        Deze stelt een event voor die geen data genereert.
        Ik heb lang gesukkeld met het gebruik van events/
        Ik heb via de site learn.microsoft.com meer informatie gevonden omtrent events.*/
        public EventHandler Meedelen;

        /*Ik maak de OnMeedelen methode aan.
         Deze is een protected virtual void methode.
        Omdat deze methode een void methode is,
        moet er geen waarde worden gereturnd.*/
        protected virtual void OnMeedelen(EventArgs e)
        {
            /*Ik maak een nieuwe EventHandler aan die ik 'meedeelHandler' noem.
             Deze stel ik gelijk aan 'Meedelen'.*/
            EventHandler meedeelHandler = Meedelen;

            /*Het volgende gebeurd met de 'meedeelHandler', wanneer 'meedeelHandler' geen waarde heeft.*/
            if(meedeelHandler != null)
            {
                meedeelHandler(this, e);
            }
        }

        public void MeedeelMethode(bool biep, TextBox tbTekstVeld)
        {
            OnMeedelen(EventArgs.Empty);

            /*Ik maak de string inhoud aan.
             Als startwaarde is dit een lege string.*/
            string inhoud = "";

            /*Ik maak de boolean 'dringend' aan.
             Ik geef deze nog geen waarde.
            Een boolean die geen waarde wordt gegeven,
            staat op false.*/
            bool dringend;

            /*Ik iterereer de string informatie binnen de array Informatie.*/
            foreach (string informatie in Informatie)
            {
                /*De informatieve tekst wordt bij elke iteratie,
                 gelijkgesteld aan inhoud + informatie.*/
                inhoud += informatie;
            }

            /*Wanneer de property 'Tijdstip' leeg is,
             wordt de boolean 'dringend' op true gezet.*/
            if (Tijdstip == null)
            {
                dringend = true;
            }

            /*Wanneer de property 'Tijdstip' wel degelijk een waarde heeft,
             en dus niet leeg is (= false), 
            staat 'dringend' op false.*/
            else
            {
                dringend = false;
            }

            if (biep == true)
            {
                System.Media.SystemSounds.Beep.Play();
            }
            tbTekstVeld.Text = "Titel: " + Titel + "\n" + "Inhoud: " + inhoud + "\n" + "Dringend: " + dringend;
        }

        public TeDoen(DateTime tijdstip, string titel, string[] informatie)
        {
            /*Teller wordt met 1 geincrement.
             Dit gebeurd logischerwijs bij elke iteratie.*/
            teller++;

            /*Id heeft dezelfde waarde als teller,
             * waardoor deze tot gevolg hiervan eigenlijk ook geincrement wordt.*/
            Id = teller;

            /*Wanneer het tijdstip groter is dan de datum van nu,
             wordt de eigenschap 'Tijdstip' gelijk gesteld aan 'tijdstip'.*/
            if (tijdstip >= DateTime.Now)
            {
                Tijdstip = tijdstip;

            }

            /*Wanneer de vorige voorwaarde niet het geval is,
             is Tijdstip gelijk aan null. (Lege waarde.)*/
            else
            {
                Tijdstip = null;
            }

            Titel = titel;
            Informatie = informatie;

        }

        public TeDoen(string text, string[] lines)
        {
            this.text = text;
            this.lines = lines;
        }

        /*Dit is mijn override ToString()-method.
         */
        public override string ToString()

        {
            /*Standaard is de string 'printString' een lege string.*/
            string printString = "";

            /*Ik itereer de string s in Informatie.
             Hier wordt s naar een string omgezet, steeds op een nieuwe lijn.
            Dit doe ik via de 'printString' variabele.*/
            foreach (string s in Informatie)
            {
                printString += s.ToString() + "\n";

            }

            /*Als Tijdstip null is,
             zal de ToString() alleen de ID, titel, Informatie en printString returnen.
            In dit geval wordt er geen Tijdstrip gereturnd.*/
            if (Tijdstip == null)
            {
                return "ID: " + Id + "\nTitel: " + Titel + "\nInformatie: " + printString;
            }

            /*Als Tijdstip niet null is (Else),
             zal de ToString() alleen de ID, titel, Informatie en printString returnen.
             In dit geval wordt, bij gevolg dat  Tijdstip niet null is,
            OOK Tijdstip gereturnd.*/
            else
            {
                return "ID: " + Id + " \ntijdstip: " + Tijdstip + "\nTitel: " + Titel + "\nInformatie: " + printString;
            }
        }

    }
}
