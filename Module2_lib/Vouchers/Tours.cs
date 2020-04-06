using Module2_lib.Utils;

namespace Module2_lib
{
    public class Tours : Voucher
    {
        public Tours(string country, decimal price, HotelType hotelClass, NutritionType food) : base(country, price, hotelClass, food)
        {
        }
        public override string VoucherType => "Tours";
    }
}
