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
    public class OrderDetailsTests
    {
        [TestMethod]
        public void OrderDetailsGetTest()
        {
            OrderDetails orderDetails = new OrderDetails();
            Assert.AreEqual("", orderDetails.GetItemName());
            Assert.AreEqual("", orderDetails.GetCustomerName());
            Assert.AreEqual(0, orderDetails.GetItemValue());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrderDetailsTest()
        {
            OrderDetails orderDetails = new OrderDetails(null, null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void OrderDetailsTest2()
        {
            OrderDetails orderDetails = new OrderDetails("", "", -1);
        }

        [TestMethod]
        public void ModifyOrderTest()
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.ModifyOrder(DetailType.CustomerName, "aaa");
            orderDetails.ModifyOrder(DetailType.ItemName, "bbb");
            orderDetails.ModifyOrder(DetailType.ItemValue, "123");
            OrderDetails expected = new OrderDetails("bbb", "aaa", 123);
            Assert.AreEqual (expected.ToString(), orderDetails.ToString());
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentNullException))]
        public void ModifyOrderTest1()
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.ModifyOrder(DetailType.Id, null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModifyOrderTest2()
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.ModifyOrder(DetailType.Id, "123");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModifyOrderTest3()
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.ModifyOrder((DetailType)5, "123456");
        }
    }
}