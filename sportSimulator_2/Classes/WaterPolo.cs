using System;
using System.Collections.Generic;
using System.Text;

namespace Sport.Classes
{
    public enum reeks { class1, class2, class3, class4 };
    class WaterPolo
    {
        // Propeties
        public string NaamSpeler { get; set; }
        public int MutsNummer { get; set; }
        public bool IsDoelMan { get; set; }
        public bool IsReserve { get; set; }
        public reeks Reeks { get; set; }

        // Methodes
        public void GooiBal()
        {
            Console.WriteLine($"ik ({NaamSpeler}) gooi de bal!");
        }

        public void StelIn(string naam, int nummer, bool doelman, bool rserve, reeks rEeks)
        {
            NaamSpeler = naam;
            MutsNummer = nummer;
            IsDoelMan = doelman;
            IsReserve = rserve;
            Reeks = rEeks;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Info over dit speler: \nnaam: {NaamSpeler}, mutsnummer: {MutsNummer}, is hij een doelman? {IsDoelMan}, is hij een reserve? {IsReserve}, welke reeks heeft hij? {Reeks}.");
        }

        // Statische methode
        static void SimuleerSpeler(WaterPolo testspeler)
        {
            for (int i = 0; i < 3; i++)
            {
                testspeler.GooiBal();
            }
        }
    }
}
