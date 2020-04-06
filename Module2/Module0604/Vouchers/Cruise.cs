using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module0604
{
    public class Cruise : BaseVoucher
    {
        public Cruise(double cost, Country country, int hotelClass, Food food) : base(cost, country, hotelClass, food)
        {
        }
    }
}
