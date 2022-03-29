using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    abstract class IceCreamFactory
    {
        public abstract string Name { get; set; }
        public  IceCreamFactory() { }
        public abstract IceCream DailySpecial(WeekDay day);
    }
}
