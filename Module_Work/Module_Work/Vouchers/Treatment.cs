
using Module_Work.Utils;

namespace Module_Work.Vouchers
{   
    public class Treatment : BaseTravelVoucher
    {
        protected override string TravelVoucherType => "Treatment";
        public override FoodGrade Type => FoodGrade.RO;
        public Treatment(int price, string countreOfRest, int classOfHotel, string foodGrage) : base(price, countreOfRest, classOfHotel, foodGrage)
        {

        }
    }
}
