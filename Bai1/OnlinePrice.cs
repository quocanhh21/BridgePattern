
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class OnlinePrice:Iprice
    {
        int price;
       
        public OnlinePrice(int price)
        {
            this.price = price;
        }

        public void DisplayDetails(string product)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("{0} có giá bán online là {1}", product, price);
        }
    }
}
