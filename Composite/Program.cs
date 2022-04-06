using System;

namespace Composite 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<OrderItem> items = new List<OrderItem>();

            OrderItem tshirt1 = new OrderItem("Tshirt", 30.0);
            OrderItem tshirt2 = new OrderItem("Tshirt", 30.0);
            OrderItem tshirt3 = new OrderItem("Tshirt", 30.0);
            OrderItem pants1 = new OrderItem("Pants", 100.0);
            OrderItem pants2 = new OrderItem("Pants", 100.0);
            



            items.Add(tshirt1);
            items.Add(tshirt2);
            items.Add(tshirt3);
            items.Add(pants1);
            //items.Add(pants2);
            
            

            MyOrder orderlist = new MyOrder(items);
            
            

            Console.WriteLine(orderlist.GetName() + "\n" + orderlist.BestPrice());
        }
    }
}
