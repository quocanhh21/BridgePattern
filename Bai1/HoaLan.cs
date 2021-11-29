using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class HoaLan:Flower
    {
        public override void Details()
        {
            Price.DisplayDetails(ProductType);
        }
    }
}
