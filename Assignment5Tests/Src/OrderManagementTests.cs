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
    public class OrderManagementTests
    {
        [TestInitialize]
        public void Init()
        {
            OrderManagement management = OrderManagement.GetInstance();
            string[] detail1 = { "SU7", "Sun", "214999" };
            string[] detail2 = { "SU7", "Huang", "214999" };
            string[] detail3 = { "SU7Max", "Sun", "299999" };
            management.CreateOrder(detail1);
            management.CreateOrder(detail2);
            management.CreateOrder(detail3);
        }

        [TestMethod]
        public void SearchOrderByDetailTest()
        {
            OrderManagement management = OrderManagement.GetInstance();
            Order[] orders = management.SearchOrderByDetail(DetailType.CustomerName, "Sun");
            Assert.AreEqual(2, orders.Length);
            string actual = "";
            foreach (Order order in orders)
            {
                actual += order.GetOrderDetails().ToString();
            }
            OrderDetails detail1 = new OrderDetails("SU7", "Sun", 214999);
            OrderDetails detail2 = new OrderDetails("SU7Max", "Sun", 299999);
            string expected = detail1.ToString() + detail2.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DeleteOrderTest()
        {
            OrderManagement management = OrderManagement.GetInstance();
            Order[] orders = management.SearchOrderByDetail(DetailType.ItemName, "SU7Max");
            Assert.IsNotNull(orders[0]);
            int deleteId = orders[0].GetId();
            management.DeleteOrder(deleteId);
            management.SearchOrderById(deleteId);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateOrderTest()
        {
            string[] invalid = { "123" };
            OrderManagement management = OrderManagement.GetInstance();
            management.CreateOrder(invalid);
        }

        [TestCleanup]
        public void Cleanup() { }
    }
}