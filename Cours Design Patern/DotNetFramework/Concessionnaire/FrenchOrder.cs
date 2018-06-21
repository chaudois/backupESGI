using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionnaire
{
    class FrenchOrder : IOrder
    {
        private double preTaxAmount;
         public double calculateAmout()
        {
            var vatAmount = preTaxAmount * 0.196;
            var amount = preTaxAmount + vatAmount;
            return amount;
        }
    }
}
