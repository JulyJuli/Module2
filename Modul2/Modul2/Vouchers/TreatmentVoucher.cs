using Modul2.Enums;

namespace Modul2.Vouchers
{
    public class TreatmentVoucher : BaseVoucher
    {
        public TreatmentVoucher(Country country, HotelClass hotelClass, Food food, double price) : base(country, hotelClass, food, price)
        {
            TypeOfVoucher = TypeOfVoucher.treatment;
        }
    }
}
