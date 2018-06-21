using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepier
{
    class Waffle : IDessert
    {
        public double price { get ; set ; }

        public double GetPrice()
        {
            return price;
        }
    }
}
