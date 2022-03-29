using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class IceCreamFactory_Koral : IceCreamFactory
    {
        public override string Name { get; set; } = "Koral";
        public override IceCream DailySpecial(WeekDay day)
        {
            if(day == WeekDay.Monday) { return new RegularIceCream(9, "Watermelon", false, "Chocolate", true); }
            else if (day == WeekDay.Tuesday) { return new GelatoIceCream(12, "Chocolate", true, false); }
            else if (day == WeekDay.Wednesday) { return new SorbetIceCream(8, "Watermelon"); }
            else if (day == WeekDay.Thursday) { return new FruitBasedIceCream(10, "Strawberry", true, "Candy"); }
            else if (day == WeekDay.Friday) { return new GelatoIceCream(12, "Vanilla", true, true); }
            else if (day == WeekDay.Saturday) { return new RegularIceCream(9, "Kiwi", true, "Chocolate", true); }
            else if (day == WeekDay.Sunday) { return new SorbetIceCream(8, "Kiwi"); }
            else { return new FruitBasedIceCream(); }
        }
    }
}
 