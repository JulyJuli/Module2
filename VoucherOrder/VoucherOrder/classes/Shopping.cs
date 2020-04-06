using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class Shopping : VoucherBase
    {
        public Shopping(int price, string country, int hotelClass, FoodType food) : base(price, country, hotelClass, food)
        {
        }

        public override string VoucherName => "Shopping";
    }
}