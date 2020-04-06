using Modul2.Enums;
using Modul2.Vouchers;
using System;
using System.Collections.Generic;

namespace Modul2
{
    public class TravelAgency
    {
        public TravelAgency()
        {
            Agency = new List<BaseVoucher>();
        }

        public void AddVoucher(BaseVoucher voucher)
        {
            Agency.Add(voucher);
        }

        public List<BaseVoucher> Agency { get; set; }

        public List<BaseVoucher> SearchVoucher(List<BaseVoucher> vouchers, int selectVoucher)
        {
            List<BaseVoucher> searchResult = new List<BaseVoucher>();

            for (int i = 0; i < vouchers.Count; i++)
            {
                if (vouchers[i].TypeOfVoucher.Equals((TypeOfVoucher)selectVoucher))
                {
                    searchResult.Add(vouchers[i]);
                }
            }

            return searchResult;
        }

        public List<BaseVoucher> SearchCountry(List<BaseVoucher> vouchers, int selectCountry)
        {
            List<BaseVoucher> searchResult = new List<BaseVoucher>();

            for (int i = 0; i < vouchers.Count; i++)
            {
                if (vouchers[i].Country.Equals((Country)selectCountry))
                {
                    searchResult.Add(vouchers[i]);
                }
            }

            return searchResult;
        }

        public List<BaseVoucher> SearchHotel(List<BaseVoucher> vouchers, int selectHotelClass)
        {
            List<BaseVoucher> searchResult = new List<BaseVoucher>();

            for (int i = 0; i < vouchers.Count; i++)
            {
                if (vouchers[i].HotelClass.Equals((HotelClass)selectHotelClass))
                {
                    searchResult.Add(vouchers[i]);
                }
            }

            return searchResult;
        }
    }
}
