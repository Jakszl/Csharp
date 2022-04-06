using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class MyOrder : IOrder
    {
        public List<OrderItem> items = new List<OrderItem>();

        public string OrderNames { get; set; } = string.Empty;
        public double Price {get; set;}

        public double DiscountedPrice { get; set; } = 0;

        public MyOrder(List<OrderItem> order)
        {
            items = order;
        }

        public string GetName()
        {
            foreach(var item in items)
            {
                OrderNames += "\n" + item.Name;
            }
            return OrderNames;
        }


        public double FourItems()
        {
            double discountedPrice = 0;
            double lowest = items.Min(item => item.Price);
            foreach (var item in items)
            {
                if (item.Price == lowest)
                {
                    item.Price = 1;
                    break;
                }
            }
            foreach (var item in items)
            {
                discountedPrice += item.Price;
            }
            foreach (var item in items)
            {
                if (item.Price == 1)
                {
                    item.Price = lowest;
                    break;
                }
            }
            return discountedPrice;
        }

        public double ThreeForTwo()
        {
            Dictionary<string, int> typesItemsCount = new Dictionary<string, int>();
            string type = string.Empty;
            double discountedPrice = 0;
            double ogprice = 0;
            foreach (var item in items)
            {
                if (typesItemsCount.TryGetValue(item.GetName(), out int count))
                    typesItemsCount[item.GetName()] = ++count;
                else
                    typesItemsCount.Add(item.GetName(), 1);
            }
            foreach (var types in typesItemsCount)
            {
                if (types.Value == 3) { type = types.Key; }
            }
            foreach (var item in items)
            {
                if (type == item.GetName()) { ogprice = item.Price; item.Price = 0; break; } 
            }
            foreach (var item in items)
            {
                discountedPrice += item.Price;
            }
            foreach (var item in items)
            {
                if (item.Price == 0) { item.Price = ogprice; break; }
            }
            return discountedPrice;
        }

        public double RegularCustomer()
        {
            double discountedPrice = 0;
            foreach (var item in items)
            {
                discountedPrice += item.Price;
            }
            return discountedPrice * 0.85;
        }


        public double BestPrice()
        {
            double discountedPrice1 = FourItems();
            double discountedPrice2 = ThreeForTwo();
            double discountedPrice3 = RegularCustomer();
            DiscountedPrice = Math.Min(discountedPrice1, Math.Min(discountedPrice2, discountedPrice3));

            return DiscountedPrice;
            
        }

    }
}
