using Modul2.Enums;

namespace Modul2.Vouchers
{
    public class ExcursionVoucher : BaseVoucher
    {
        public ExcursionVoucher(Country country, HotelClass hotelClass, Food food, double price) : base(country, hotelClass, food, price)
        {
            TypeOfVoucher = TypeOfVoucher.excursions;
        }
    }
}
