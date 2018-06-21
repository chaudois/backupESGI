using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionnaire
{
    class LuxembourgishOrder : IOrder
    {
        private double preTaxServiceAmount;
        private double preTaxMaterialAmount;
        public double calculateAmout()
        {
            var vatAmount = preTaxServiceAmount  * 0.12 + preTaxMaterialAmount * 0.15;
            var preTaxAmount = preTaxServiceAmount + preTaxServiceAmount;
            var amount = preTaxAmount + vatAmount;
            return amount;
        }
    }
}
