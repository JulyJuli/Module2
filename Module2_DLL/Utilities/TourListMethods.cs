using System;
using System.Collections.Generic;

namespace Module2_DLL.Utilities
{
    public static class TourListMethods
    {
        public static List<BaseTour> GetSuitableTours(List<BaseTour> toursList, int budget, string country, int hotelRank)
        {
            var suitableTours = new List<BaseTour>();

            foreach (var tour in toursList)
            {
                if (tour.Price <= budget && tour.Country.Equals(country) && tour.HotelRank >= hotelRank)
                {
                    suitableTours.Add(tour);
                }
            }

            return suitableTours;
        }

        public static void PrintSuitableTours(List<BaseTour> suitableTours)
        {
            Console.WriteLine("Here's what we found for you:");

            if (suitableTours.Count > 0)
            {
                suitableTours.ForEach(tour => Console.WriteLine(tour));
            }
            else
            {
                Console.WriteLine("No suitable tours for now, sorry!");
            }
        }
    }
}
