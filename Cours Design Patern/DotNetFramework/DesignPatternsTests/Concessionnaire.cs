using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Concessionaire;
namespace DesignPatterns.Tests
{
    [TestClass]
    class Concessionnaire
    {
        [TestMethod]
        public void shoudl_create_valid_order()
        {
            OrderCreator.CreateNewOrder(true);

            Order order = OrderCreator.order;

            Assert.IsTrue(order.IsValid());
        }
    }
}
