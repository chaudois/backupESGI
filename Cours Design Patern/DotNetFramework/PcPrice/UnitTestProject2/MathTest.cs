using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematiques.cs;
namespace UnitTestProject2
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void should_return_simple_result()
        {
            Addition addition = new Addition();
            Expression expression = new Expression(new Value(2), new Value(3), addition);
            Assert.AreEqual(expression.evaluate(), 5);
        }

        //((4-5)*2)+(4*(1+6))
        [TestMethod]
        public void should_return_complex_result()
        {
            
            Expression expression = 
                new Expression(
                    new Expression(
                        new Expression(
                            new Value(4),
                            new Value(5),
                            new Substract()),
                        new Value(2),
                        new Multiply()),
                    new Expression(
                        new Value(4),
                        new Expression(
                            new Value(1),
                            new Value(6),
                            new Addition()),
                        new Multiply()),
                new Addition());
            Assert.AreEqual(expression.evaluate(), 26);
        }
    }
}
