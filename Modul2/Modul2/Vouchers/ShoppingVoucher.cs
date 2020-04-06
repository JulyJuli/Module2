using Modul2.Enums;

namespace Modul2.Vouchers
{
    public class ShoppingVoucher : BaseVoucher
    {
        public ShoppingVoucher(Country country, HotelClass hotelClass, Food food, double price) : base(country, hotelClass, food, price)
        {
            TypeOfVoucher = TypeOfVoucher.shopping;
        }
    }
}
