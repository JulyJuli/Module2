using Module2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Classes
{
    public class Rest : BaseCard
    {
        public Rest(decimal price, CountriesEnum country, HotelTypes hotelClass, FoodTypes food)
            : base(price, country, hotelClass, food)
        {
        }

        public override TypesOfCard TypeCard => TypesOfCard.rest;

    }
}
