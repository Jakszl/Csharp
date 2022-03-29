using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class IceCreamFactory_Grycan : IceCreamFactory
    {
        public override string Name { get; set; } = "Grycan";

        public override IceCream DailySpecial(WeekDay day)
        {
            if (day == WeekDay.Monday) { return new FruitBasedIceCream(10, "Strawberry", true, "Candy"); }
            else if (day == WeekDay.Tuesday) { return new FruitBasedIceCream(10, "Raspberry", false, "Candy"); }
            else if (day == WeekDay.Wednesday) { return new SorbetIceCream(8,"Pear"); }
            else if (day == WeekDay.Thursday) { return new FruitBasedIceCream(10, "Banana",true, "Vanilla"); }
            else if (day == WeekDay.Friday) { return new GelatoIceCream(12, "Chocolate", true, false); }
            else if (day == WeekDay.Saturday) { return new RegularIceCream(9, "Watermelon", false, "Chocolate", true); }
            else if (day == WeekDay.Sunday) { return new SorbetIceCream(8,"Watermelon"); }
            else { return new GelatoIceCream(); }
        }
    }
}
