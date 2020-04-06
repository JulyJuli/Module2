using System.Collections.Generic;

namespace Module2_lib
{
    public class Offers
    {
        public static List<Voucher> Vouchers { get; set; }
        public Offers()
        {
            Vouchers = new List<Voucher>();
        }

        public static string DisplayAllInfo()
        {
            string res = string.Empty;

            foreach (var voucher in Vouchers)
            {
                res += voucher.GetInfo();
                res += "\n";
            }

            return res;

        }

        //public static void CountrySelect()
        //{

        //}
    }
}
