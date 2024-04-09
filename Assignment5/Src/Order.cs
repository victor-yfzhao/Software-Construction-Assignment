using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Src
{
    public class Order
    {
        public int id { set; get; }
        public OrderDetails detail { set; get; }

        public string ItemName { get
            {
                return detail.itemName;
            } 
        }

        public string CustomerName
        {
            get
            {
                return detail.customerName;
            }
        }

        public int ItemValue
        {
            get
            {
                return detail.itemValue;
            }
        }

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
