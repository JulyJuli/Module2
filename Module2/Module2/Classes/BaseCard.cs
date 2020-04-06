using Module2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
     public abstract class BaseCard
    {

        //Путевка характеризуется стоимостью, страной отдыха,
        //классом отеля, питанием(только завтраки, все включено, без питания).
        
            private decimal _price;
        public BaseCard(decimal price, CountriesEnum country, HotelTypes hotelClass, FoodTypes food)
        {
            Price = price;
            Country = country;
            HotelClass = hotelClass;
            Food = food;
        }
        public abstract TypesOfCard TypeCard { get; }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public CountriesEnum Country { get; set; }

        public  HotelTypes HotelClass { get; set; }
        public FoodTypes Food { get;set; }

        public override string ToString()
        {
            return $"Type of Card: {TypeCard,8}|Price: {Price,4}|Country: {Country,7}|HotelClass {HotelClass,8}|Food: {Food,12}|";
        }

    }
}
