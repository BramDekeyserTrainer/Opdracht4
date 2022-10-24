using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        /*Ik maak een nieuwe list aan.
         Deze noem ik container.*/
        internal List<T> container { get; set; } = new List<T>();

        internal T Huidig;

        /*Deze boolean kan ik later mee nagan of iets leeg is.
         By default is deze leeg. (Dus true)*/
        public readonly bool IsLeeg = true;

        /*Ik maak de integer 'Count' aan.
         Deze geef ik vervolgens ook een getter.
         Doormiddel van deze getter return ik Count.*/
        public int Count = -1;

        /*Ik maak het generische publieke HuidigElement aan.
         Ik heb geprobeerd deze readonly te maken,
        maar kreeg de melding dat er hier geen readonly gebruikt kan worden.
        Omwille van die reden, heb ik de readonly in commentaar gezet.
        Ik heb HuidigElement ook meteen haar getter gegeven die 'Huidig' returnd.*/
        public /*readonly*/ T HuidigElement
        {
            get { return this.Huidig; }
        }

        public T Toevoegen(T iets)
        {
            container.Add(iets);

            /*Als de container leeg is, wordt Huidig gereturnd.
             In dit geval stel ik 'Huidig' gelijk aan 'iets'.*/
            if (container.Count() == 0)
            {
                Huidig = iets;
                return Huidig;
            }

            /*Als een methode geen void is, moet er altijd iets gereturnd worden.
             Daarom moet ik bij de else-statement een return waarde geven.
            Ik return default.*/
            else
            {
                return default(T);
            }

            /*Ik increment Count met 1.*/
            Count++;

        }

        /*Een funnctie waarmee ik één item verwijder.*/
        public T Verwijderen()
        {
            container.Remove(Huidig);
            Huidig = container.First();

            /*Ik decrement Count met 1.*/
            Count--;

            return Huidig;
        }

        /*We gaan naar de volgende positie (index).*/
        public T Volgende()
        {
            int positie = container.IndexOf(Huidig);
            Huidig = container[positie + 1];
            return Huidig;
        }

        /*De public void Leegmaken() maakt de container leeg,
         en maakt van 'Huidig' een default object.*/
        public void Leegmaken()
        {
            container.Clear();
            Huidig = default;

            /*Ik zet Count weer op de default waarde.*/
            Count = -1;
        }

        /*Ik zet Huidig achteraan in de rij.*/
        public T ZetAchteraan()
        {
            Huidig = container.Last();
            int huidigePositie = container.Count - 1;
            container[huidigePositie] = this.Huidig;
            return Huidig;
        }

        /*Ik maak een override string method 'ToString'.
 Deze weergeeft alle informatie uit 'container' in een string.*/
        public override string ToString()
        {
            /*De informatie wordt in een variabele 'inhoud' gegoten.
             Alle container items worden in de string gegoten, en krijgen
            '/' als separator.
            Ik gebruik hiervoor een foreach.*/
            string inhoud = null;
            foreach (T iets in container)
            {
                inhoud += iets.ToString();
                inhoud += "\n";
            }

            /*Ik return de inhoud.*/
            return inhoud;
        }

        /*Ik maak een publieke methode aan.
         Deze maakt een kopij aan van de rij.
        Een shallow kopij, wordt er een kopij van het oorspronkelijke object opgeslagen,
        en enkel een referentie-adres uiteindelijk gekopieerd.
        Bij een deep kopij daarentegen, wordt zowel het oorspronkelijke object als
        de repititieve kopijen opgeslagen.
        In dit geval maken we een nieuwe lijst aan die kopieert. 
        Dit is een gewone kopie.*/
        public List<T> Kopieer()
        {
            List<T> fouterij = new List<T>();

            /*'fouterij' is gelijk aan de return waarde van de functie Kopieer().*/
            fouterij = Kopieer();

            /*Ik return de kopie.*/
            return fouterij;
        }




    }
}
