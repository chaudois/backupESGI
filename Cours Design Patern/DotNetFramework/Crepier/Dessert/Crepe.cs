using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepier
{
    public class Crepe : IDessert
    {
        public double price { get ; set ; }

        public double GetPrice()
        {
            return price;
        }
    }
}
