using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class Tours : VoucherBase
    {
        public Tours(int price, string country, int hotelClass, FoodType food) : base(price, country, hotelClass, food)
        {
        }

        public override string VoucherName => "Tours";
    }
}