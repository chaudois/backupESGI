using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Concessionaire
{
    class ForwardOrder:Order
    {
        public ForwardOrder()
        {
            isValid = false;
        }
    }
}
