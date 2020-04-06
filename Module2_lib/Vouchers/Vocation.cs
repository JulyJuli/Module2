using Module2_lib.Utils;

namespace Module2_lib
{
    public class Vocation : Voucher
    {
        public override string VoucherType => "Vocation";
        public Vocation(string country, decimal price, HotelType hotelClass, NutritionType food) : base(country, price, hotelClass, food)
        {
        }
    }
}
