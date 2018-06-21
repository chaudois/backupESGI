using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepier
{
    public interface IDessert
    {
        double GetPrice();
        double price { get; set; }
    }
}
