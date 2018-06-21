using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Concessionaire
{
    public static  class OrderCreator
    {
        public static  Order order { get; set; }

        public static void CreateNewOrder(bool payOnTheSpot)
        {
            order = CreateOrder(payOnTheSpot);
            if (order.IsValid())
            {
                order.Pay();
            }
        }
        private static  Order CreateOrder(bool payOnTheSpot)
        {
            if (payOnTheSpot)
            {
                return new SpotOrder();
            }
            else
            {
                return new ForwardOrder();
            }

        }
    }
}
