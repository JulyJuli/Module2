using Modul2.Enums;
using System;
using System.Collections.Generic;

namespace Modul2.Vouchers
{

    public abstract class BaseVoucher
    {
        public BaseVoucher(Country country, HotelClass hotelClass, Food food, double price)
        {
            Country = country;
            HotelClass = hotelClass;
            Food = food;
            Price = price;
        }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                    Console.WriteLine("Incorrect! Value must be >0");
            }

        }

        public Country Country { get; set; }

        public HotelClass HotelClass { get; set; }

        public Food Food { get; set; }

        public TypeOfVoucher TypeOfVoucher { get; set; }
        public override string ToString()
        {
            return $"Country: {Country,9}|\tType of voucher: {TypeOfVoucher,10}|\tHotel Class: {HotelClass}|\tFood: {Food,15}|\tPrice: {Price,5}|";
        }

        public static void PrintInfo(List<BaseVoucher> vouchers)
        {
            foreach (var item in vouchers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
