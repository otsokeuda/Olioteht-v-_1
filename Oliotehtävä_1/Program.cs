using System;

namespace Oliotehtävä_1
{
    class Kirjasto
    {
        //kentät 
        private int sivumäärä;
        private string kirjailija;
        private string nimi;

        //metodit 
        public int PalautaSivumäärä()
        {
            Console.WriteLine("sivumäärä metodia käytetty");
            return sivumäärä; 
        }
        public string PalautaKirjailija()
        {
            Console.WriteLine("kirjailija metodia käytetty");
            return kirjailija; 
        }
        public string PalautaNimi()
        {
            Console.WriteLine("nimi metodia käytetty");
            return nimi; 
        }

        //Oletuskonstruktori
        public Kirjasto()
        {
            sivumäärä = 0;
            kirjailija = "";
            nimi = "";
            Console.WriteLine("Oletuskonstruktoria käytetty");
        }

        //Ylikuormitettu konstruktori
        public Kirjasto(int u_sivumäärä, string
        u_kirjailija, string u_nimi)
        {
            sivumäärä = u_sivumäärä;
            kirjailija = u_kirjailija;
            nimi = u_nimi;
        }

        public int Sivumäärä // Ominaisuusfunktio
        {
            set
            {
                sivumäärä = value;
                Console.WriteLine("setteriä käytetty");
            }
            get
            {
                Console.WriteLine("getteriä käytetty");
                return sivumäärä;
            }
        }
        public string Kirjailija // Ominaisuusfunktio
        {
            set
            {
                Console.WriteLine("setteriä käytetty");
                kirjailija = value;
            }
            get
            {
                Console.WriteLine("getteriä käytetty");
                return kirjailija;
            }
        }
        public string Nimi // Ominaisuusfunktio
        {
            set
            {
                Console.WriteLine("setteriä käytetty");
                nimi = value;
            }
            get
            {
                Console.WriteLine("getteriä käytetty");
                return nimi;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Oliotehtävä 1 / Otso Rantala");
            Console.WriteLine("");

            Kirjasto kirja = new Kirjasto();
            Console.WriteLine("kirja olio luotu");
            Console.WriteLine("");

            kirja.PalautaSivumäärä();
            kirja.PalautaKirjailija();
            kirja.PalautaNimi();
            Console.WriteLine("");

            int u_sivumäärä = 101;
            string u_kirjailija = "King";
            string u_nimi = "It";

            kirja.Sivumäärä = u_sivumäärä;
            kirja.Kirjailija = u_kirjailija;
            kirja.Nimi = u_nimi;

            Console.WriteLine("");
            Console.WriteLine("Sivumäärä on " + u_sivumäärä);
            Console.WriteLine("");
            Console.WriteLine("Kirjailija on " + u_kirjailija);
            Console.WriteLine("");
            Console.WriteLine("Kirjan nimi on " + kirja.Nimi);
        }
    }





}
