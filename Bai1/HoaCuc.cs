using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    public class HoaCuc:Flower
    {
        public override void Details()
        {
            Price.DisplayDetails(ProductType);
        }
    }
}
