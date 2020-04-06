using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class Relaxation : VoucherBase
    {
        public Relaxation(int price, string country, int hotelClass, FoodType food) : base(price, country, hotelClass, food)
        {
        }

        public override string VoucherName => "Relaxation";
    }
}