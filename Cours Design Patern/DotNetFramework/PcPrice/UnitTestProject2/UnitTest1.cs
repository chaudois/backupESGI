using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PcPrice;
namespace UnitTestProject
{
    [TestClass]
    public class PcPriceTest
    {
        [TestMethod]
        public void should_calculate_total_option_price()
        {
            Pc monPc = new Pc(new Dictionary<string, double>
            {
                {"Nvidia",200 }, 
                {"WD green",75 }
            },150);
            Assert.AreEqual(monPc.getPrice(), 425);
            
        }
     }
}
