using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematiques.cs
{
    public class Expression:IEvaluable
    {
        private double value;
        private IEvaluable operande1, operande2;

        private Operation operation;

        public Expression(IEvaluable op1, IEvaluable op2,Operation operation)
        {
            operande1 = op1;
            operande2 = op2;
            this.operation = operation;
        }
        
        public double evaluate()
        {
            if (operande2 == null) return value;
            return operation.Calulate(operande1.evaluate(), operande2.evaluate());
        }
    }
}
