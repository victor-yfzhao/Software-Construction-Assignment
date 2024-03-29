using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Src
{
    public class Order
    {
        private int id;
        private OrderDetails detail;

        public Order()
        {
            id = this.GetHashCode();
            detail = new OrderDetails();
        }
        
        public Order(OrderDetails _detail)
        {
            if (_detail == null) throw new ArgumentNullException(nameof(_detail));
            id = this.GetHashCode();
            detail = _detail;
        }

        public int GetId()
        {
            return id;
        }

        public OrderDetails GetOrderDetails()
        {
            return detail;
        }

        public override string ToString()
        {
            return "Id: \t\t" + id + "\n" + detail.ToString() + "\n";
        }
    }
}
