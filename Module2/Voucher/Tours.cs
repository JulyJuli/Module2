namespace Module2.Voucher
{
    public class Tours: BaseVoucher
    {
        public Tours(int price, int classHotel, string voucherName, string country, string food)
           : base(price, classHotel, voucherName, country, food)
        {
        }
        public override string VoucherName => "Tours";
    }
}
