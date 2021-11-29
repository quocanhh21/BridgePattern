using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class ShowroomPrice:Iprice
    {
        int price;

        public ShowroomPrice(int price)
        {
            this.price = price;
        }

        public void DisplayDetails(string product)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("{0} có giá bán tại showroom là {1}", product, price);
        }
    }
}
