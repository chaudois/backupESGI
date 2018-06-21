using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepier
{
    class Strawberry : Extra
    {

        double price { get; set; }
        public double GetPrice()
        {
            return 0.5;
        }
    }
}
