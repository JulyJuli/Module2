using Module2_OlehHarmash.Interfaces;
using Module2_OlehHarmash.VauchersBase;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;


namespace Module2_OlehHarmash
{
    public class Program
    {
        static void Main(string[] args)
        {

            var startDate = DateTime.Now.AddDays(1);
            var endDate = DateTime.Now.AddDays(3);

            var vauchers = new List<ITravel>
            {
                new OneDay("Milan Shoping", "Shoping", 200, "Italy", startDate, startDate),
                new OneDay("Rome Shoping", "Shoping", 300, "Italy", startDate, startDate),
                new MultiDay("Historical Rome", "Excursion", 400, "Italy", startDate, endDate, "Main Hotel", 3, "OB"), // OB - only breakfast
                new MultiDay("Historical Kyiv", "Excursion", 400, "Ukrain", startDate, endDate, "Ibis", 3, "OB"),
                new MultiDay("Long wave", "Cruise", 4000, "Italy", startDate, endDate, "Small boat", 5, "AI")
            };


            Console.WriteLine("\n  Cheaper then 400$:");
            foreach ( var item in vauchers)
            {
                if (item.TravelPrice < 400)
                {
                    item.PrintInfo();
                }
            }

            Console.WriteLine("\n  In range 400$ - 1000$:");
            foreach (var item in vauchers)
            {
                if (item.TravelPrice >= 400 && item.TravelPrice <= 1000)
                {
                    item.PrintInfo();
                }
            }

            Console.WriteLine("\n  Cruise:");
            foreach (var item in vauchers)
            {
                if (item.TravelType == "Cruise")
                {
                    item.PrintInfo();
                }
            }
        }
    }
}
