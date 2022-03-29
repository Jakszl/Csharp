using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IceCreamFactory_Grycan factory1 = new IceCreamFactory_Grycan();
            IceCreamFactory_Koral factory2 = new IceCreamFactory_Koral();

            IceCreamShop shop = new IceCreamShop();

            foreach(WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                if(day<=WeekDay.Wednesday) { shop.Factory = factory1; }
                else { shop.Factory = factory2; }

                Console.WriteLine("\n"+day + "\nIce Cream Factory: " + shop.Factory.Name + "\n" + shop.AdvertiseDailySpecial(day));
            }

            

        }
    }
}
