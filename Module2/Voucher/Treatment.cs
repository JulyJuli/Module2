namespace Module2.Voucher
{
    public class Treatment : BaseVoucher
    {
        public Treatment(int price, int classHotel, string voucherName, string country, string food)
           : base(price, classHotel, voucherName, country, food)
        {
        }
        public override string VoucherName => "Treatment";
    }
}
