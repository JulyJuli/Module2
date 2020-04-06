using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class Cruise : VoucherBase
    {
        public Cruise(int price, string country, int hotelClass, FoodType food) : base(price, country, hotelClass, food)
        {
        }

        public override string VoucherName => "Cruise";
    }
}