
using Module_Work.Utils;

namespace Module_Work.Vouchers
{
    public class Shopping : BaseTravelVoucher
    {
        protected override string TravelVoucherType => "Shopping";
        public override FoodGrade Type => FoodGrade.BB;
        public Shopping(int price, string countreOfRest, int classOfHotel, string foodGrage) : base(price, countreOfRest, classOfHotel, foodGrage)
        {

        }
    }
}
