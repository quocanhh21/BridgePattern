using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    public abstract class Flower
    {
        public Iprice Price { get; set; }
        public string ProductType { get; set; }
        public abstract void Details();




    }
}
