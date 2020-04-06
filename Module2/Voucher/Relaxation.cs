namespace Module2.Voucher
{
    public class Relaxation: BaseVoucher
    {
        public Relaxation(int price, int classHotel, string voucherName, string country, string food)
           : base(price, classHotel, voucherName, country, food)
        {
        }
        public override string VoucherName => "Relaxation";

    }
}
