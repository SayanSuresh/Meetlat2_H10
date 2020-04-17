using System;
using System.Collections.Generic;
using System.Text;

namespace Sport.Classes
{
    public enum reeks { class1, class2, class3, class4 };
    class WaterPolo
    {
        // Propeties
        private string NaamSpeler { get; set; }
        private int MutsNummer { get; set; }
        private bool IsDoelMan { get; set; }
        private bool IsReserve { get; set; }
        private reeks Reeks { get; set; }

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
