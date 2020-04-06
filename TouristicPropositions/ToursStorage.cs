
using System.Collections.Generic;
using TouristicPropositions.Classes;

namespace TouristicPropositions
{
    public class ToursStorage
    {
        public ToursStorage()
        {
            Tours = new List<BasiVoucher>();
        }

        public List<BasiVoucher> Tours { get; set; }

        public List<BasiVoucher> GetNeededTour (int maxPrice, string country, string classHotel)
        {
            List<BasiVoucher> NeededTours = new List<BasiVoucher>();
            foreach (BasiVoucher tour in Tours)
            {
                if ((tour.Price < maxPrice) && (tour.Country.Equals(country)) && (tour.HotelClass.Equals(classHotel)))
                {
                    NeededTours.Add(tour);
                }
            }
            return NeededTours;
        }

        

    }
}
