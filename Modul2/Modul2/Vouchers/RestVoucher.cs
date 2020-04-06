using Modul2.Enums;

namespace Modul2.Vouchers
{
    public class RestVoucher : BaseVoucher
    {
        public RestVoucher(Country country, HotelClass hotelClass, Food food, double price) : base(country, hotelClass, food, price)
        {
            TypeOfVoucher = TypeOfVoucher.rest;
        }
    }
}
