using Module2_lib.Utils;

namespace Module2_lib
{
    public class Cruise : Voucher
    {
        public Cruise(string country, decimal price, HotelType hotelClass, NutritionType food) : base(country, price, hotelClass, food)
        {
        }

        public override string VoucherType => "Cruise";
    }
}
