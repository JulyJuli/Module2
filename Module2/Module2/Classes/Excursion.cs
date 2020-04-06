using Module2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Classes
{
    public class Excursion : BaseCard
    {
        public override TypesOfCard TypeCard => TypesOfCard.excursions;

        public Excursion(decimal price, CountriesEnum country, HotelTypes hotelClass, FoodTypes food)
            :base(price,country, hotelClass, food)
        {
            Price = price;
            Country = country;
            HotelClass = hotelClass;
            Food = food;
        }


    }
}
