using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematiques.cs
{
    public class Value : IEvaluable
    {
        private double value;
        public Value(double value)
        {
            this.value = value;
        }
        public double evaluate()
        {
            return value;
        }
    }
}
