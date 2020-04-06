using Module2_DLL.Enums;

namespace Module2_DLL
{
    public class Medical : BaseTour
    {
        public Medical(int price, string country, Meals mealType, int hotelRank)
            : base(price, country, mealType, hotelRank)
        {
            Price = price;
            Country = country;
            MealType = mealType;
            HotelRank = hotelRank;
        }

        public override string TourType => "Medical";
    }
}
