using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Src
{
     public class OrderManagement
     {
        private List<Order> orders;
        
        private static OrderManagement INSTANCE = new OrderManagement();

        private OrderManagement() 
        {
            orders = new List<Order>();
        }

        public static OrderManagement GetInstance()
        {
            return INSTANCE;
        }

        public Order CreateOrder(string [] detail)
        {
            if (detail.Length != 3) throw new Exception("Unable to create order for invalid input!");
            Order _order = new Order(new OrderDetails(detail[0], detail[1], Convert.ToInt32(detail[2])));
            orders.Add(_order);
            return _order;
        }

        public Order [] SearchOrderByDetail(DetailType type, string _detail)
        {
            if (_detail == null) throw new ArgumentNullException();
            switch (type)
            {
                case DetailType.ItemName:
                    var query0 = from order in orders
                                 where order.GetOrderDetails().GetItemName() == _detail
                                 orderby order.GetOrderDetails().GetItemValue()
                                 select order;
                    return query0.ToArray();
                case DetailType.CustomerName:
                    var query1 = from order in orders
                                 where order.GetOrderDetails().GetCustomerName() == _detail
                                 orderby order.GetOrderDetails().GetItemValue()
                                 select order;
                    return query1.ToArray();
                case DetailType.ItemValue:
                    var query2 = from order in orders
                                 where order.GetOrderDetails().GetItemValue() == Convert.ToInt32(_detail)
                                 orderby order.GetOrderDetails().GetItemValue()
                                 select order;
                    return query2.ToArray();
                default:
                    throw new Exception("Unable to search by such types!");
            }
        }

        public Order SearchOrderById(int id)
        {
            foreach (var order in orders)
            {
                if(order.GetId() == id) return order;
            }
            throw new Exception("Unable to find order whose id is: " +  id);
        }

        public void ModifyOrder(Order order, DetailType type, string detail)
        {
             order.GetOrderDetails().ModifyOrder(type, detail);      
        }

        public void DeleteOrder(int id)
        {
            foreach (var order in orders)
            {
                if (order.GetId() == id)
                {
                    orders.Remove(order);
                    return;
                }
            }
            throw new Exception("Unable to find order whose id is: " + id);
        }
    }
}
