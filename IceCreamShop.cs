using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class IceCreamShop
    {
        public IceCreamFactory Factory { get; set; }


        public string AdvertiseDailySpecial(WeekDay day)
        {
            if (Factory == null)
                return "Ivalid factory";
            else
                return "\n"+ Factory.DailySpecial(day).GetInfo();
            
        }
    }
}
