using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Concessionaire
{
    public abstract class Order
    {
        protected bool isValid;
        public enum PayementType
        {
            Spot,
                Forward
        };

        public void Pay()
        {

        }
        public bool IsValid()
        {
            return isValid;
        }
    }
}
