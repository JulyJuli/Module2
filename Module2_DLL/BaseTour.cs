using Module2_DLL.Enums;

namespace Module2_DLL
{
    public abstract class BaseTour
    {
        private int _price = 100;
        private int _hotelRank = 3;
        public const int _minHotelRank = 1;
        public const int _maxHotelRank = 5;

        public BaseTour(int price, string country, Meals mealType, int hotelRank)
        {
            Price = price;
            Country = country;
            MealType = mealType;
            HotelRank = hotelRank;
        }

        public abstract string TourType { get; }

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

        public string Country { get; set; }

        public Meals MealType { get; set; }

        public int HotelRank
        {
            get => _hotelRank;
            set
            {
                if(value >= _minHotelRank && value <= _maxHotelRank)
                {
                    _hotelRank = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{TourType} tour to a {HotelRank}-star hotel in {Country}, meals: {MealType}, only ${Price}!!";
        }
    }
}
