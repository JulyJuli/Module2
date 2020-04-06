using System;
using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public abstract class VoucherBase : IEquatable<VoucherBase> , IComparable<VoucherBase>
    {
        private const int minHotelClass = 1;
        private int maxHotelClass = 5;
        private int _hotelClass = minHotelClass;
        
        private int _price = 0;

        protected VoucherBase(int price, string country, int hotelClass, FoodType food)
        {
            Price = price;
            Country = country;
            HotelClass = hotelClass;
            Food = food;
        }

        public int Price
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
        
        public FoodType Food { get; }
        
        public string Country { get; }

        public int HotelClass
        {
            get => _hotelClass;
            set
            {
                if (value >= minHotelClass || value <= maxHotelClass)
                {
                    _hotelClass = value;
                }
                else
                {
                    Console.WriteLine($"Hotel class is invalid. Min = {minHotelClass}, Max = {maxHotelClass}.");
                }
            } 
        }

        public bool Equals(VoucherBase other)
        {
            if (other == null) return false;
            return (Price.Equals(other.Price));
        }

        public int CompareTo(VoucherBase other)
        {
            if (other == null)
                return 1;
            else
                return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Voucher name = {VoucherName}, price = {Price}, country = {Country}, hotel class = {HotelClass}, food type = {Food}";
        }
        
        public abstract string VoucherName { get; }
    }
}