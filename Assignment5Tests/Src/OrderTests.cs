using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment5.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Src.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GetIdTest()
        {
            Order order = new Order();
            Assert.AreEqual(order.GetHashCode(), order.GetId());
        }

        [TestMethod]
        public void GetOrderDetailsTest()
        {
            Order order = new Order();
            OrderDetails details = new OrderDetails();
            Assert.AreEqual(details.ToString(), order.GetOrderDetails().ToString());
        }

        [TestMethod]
        public void GetOrderDetailsTest1()
        {
            OrderDetails details = new OrderDetails("aaa", "bbb", 1);
            Order order = new Order(details);
            Assert.AreEqual(details.ToString(), order.GetOrderDetails().ToString());
        }

        [TestMethod]
        public void ToStringTest()
        {
            Order order = new Order();
            string expected = "Id: \t\t" + order.GetId() + "\n" + order.GetOrderDetails().ToString() + "\n";
            Assert.AreEqual(expected, order.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOrderDetailsTest2()
        {
            Order order = new Order(null);
            order.GetOrderDetails();
        }
    }
}