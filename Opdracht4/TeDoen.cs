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

        /*Ik declareer de nodige properties.*/
        private DateTime? Tijdstip { get; set; }
        public string Titel;
        public string[] Informatie;
        private string text;
        private string[] lines;

        /*Hieronder heb ik de declaratie van de mededeling in commentaar gezet.
         Deze geeft namelijk een foutmelding.
        Ik heb deze nog niet opgelost gekregen.*/

        //public event Meedelen meedelen;

        public TeDoen(DateTime tijdstip, string titel, string[] informatie)
        {
            /*Teller wordt met 1 geincrement.*/
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
