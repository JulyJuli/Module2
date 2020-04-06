using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class Treatment : VoucherBase
    {
        public Treatment(int price, string country, int hotelClass, FoodType food) : base(price, country, hotelClass, food)
        {
        }

        public override string VoucherName => "Treatment";
    }
}