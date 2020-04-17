using System;
using Sport.Classes;
namespace sportSimulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterPolo speler1 = new WaterPolo();
            speler1.StelIn("jelle",5,false,false,reeks.class1);
            WaterPolo speler2 = new WaterPolo();
            speler2.StelIn("jan", 5, false, false, reeks.class1);
            speler1.ToonInfo();
            speler2.ToonInfo();

        }
    }
}
