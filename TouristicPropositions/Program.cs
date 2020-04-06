using System;
using System.Collections.Generic;
using TouristicPropositions.Classes;



namespace TouristicPropositions
{
    public class Program
    {
        static void Main(string[] args)
        {
            ToursStorage joinUp = new ToursStorage();
            joinUp.Tours.Add(new Cruise(10000, "Spain", "3*", "ALL"));
            joinUp.Tours.Add(new Excursions(8000, "Germany", "4*", "BB"));
            joinUp.Tours.Add(new Cruise(200000, "Bali", "3*", "BB"));
            joinUp.Tours.Add(new Relax(10000, "Egypt", "5*", "ALL"));
            joinUp.Tours.Add(new Relax(10000, "TurKey", "4*", "RO"));
            joinUp.Tours.Add(new Shopping(15000, "Italy", "4*", "BB"));
            joinUp.Tours.Add(new Therapy(12000, "Ukraine", "5*", "ALL"));

            Console.WriteLine("Enter maximum price");
            int price; 
            bool validation = int.TryParse(Console.ReadLine(), out price);

            Console.WriteLine("Enter the Country");
            string country = Console.ReadLine();

            Console.WriteLine("Enter the class of the hotel in the format 4* or 2*");
            string classOfHotel = Console.ReadLine();

            List<BasiVoucher> neededTours = joinUp.GetNeededTour(price, country, classOfHotel);
            
            foreach (BasiVoucher tour in neededTours)
            {
                tour.GetPrintInfo();
            }

            Console.WriteLine("------------------");
            Console.WriteLine("All the tours sorted by prices");
            
            joinUp.Tours.Sort();
            foreach (BasiVoucher tour in joinUp.Tours)
            {
                tour.GetPrintInfo();
            }

            Console.ReadKey();


        }

        

    }
}
