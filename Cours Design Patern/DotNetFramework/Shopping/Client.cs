using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Client
    {
        ICloanableOrder order = new Order();
        public void CreateOrderFromAnother()
        {
            var newOrder = order.Clone();
        }
    }
}
