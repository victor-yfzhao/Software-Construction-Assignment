using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_EF
{
    enum DetailType
    {
        OrderId,
        Item,
        Customer,
        TotalPrice
    }

    internal class OrderManagement
    {
        private static OrderManagement INSTANCE = new OrderManagement();
        public static OrderManagement management { get { return INSTANCE; } }

        private OrderManagement() { }

        public int CreateOrder(OrderDetail detail, Customer customer)
        {
            var order = new Order();
            order.Detail = detail;
            order.Customer = customer;
            order.CustomerName = customer.CustomerName;
            order.CreatedDate = DateTime.Now;
            using (var db = new OrderDatabase())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return db.Orders.Find(order).OrderId;
            }
        }

        public void DeleteOrder(int id)
        {
            using (var db = new OrderDatabase())
            {
                var order = db.Orders.Find(id);
                if (order == null)
                {
                    throw new Exception("Cannot find such Order");
                }
                var detail = order.Detail;
                db.Orders.Remove(order);
                db.Details.Remove(detail);
                db.SaveChanges();
            }
        }

        public Order [] SearchOrder(DetailType type, string _detail)
        {
            if (_detail == null) throw new ArgumentNullException();
            using (var db = new OrderDatabase())
            {
                switch (type)
                {
                    case DetailType.OrderId:
                        var query0 = from order in db.Orders
                                     where order.OrderId == Convert.ToInt32(_detail)
                                     orderby order.Detail.TotalPrice
                                     select order;
                        return query0.ToArray();
                    case DetailType.Item:
                        var query1 = from order in db.Orders
                                     where order.Detail.Items.Any(itemPair => itemPair.Key.ItemName == _detail)
                                     orderby order.Detail.TotalPrice
                                     select order;
                        return query1.ToArray();
                    case DetailType.Customer:
                        var query2 = from order in db.Orders
                                     where order.CustomerName == _detail
                                     orderby order.Detail.TotalPrice
                                     select order;
                        return query2.ToArray();
                    case DetailType.TotalPrice:
                        var query3 = from order in db.Orders
                                     where order.Detail.TotalPrice == Convert.ToInt32(_detail)
                                     orderby order.OrderId
                                     select order;
                        return query3.ToArray();
                    default:
                        throw new Exception("Unable to search by such types!");
                }
            }
        }


    }
}
