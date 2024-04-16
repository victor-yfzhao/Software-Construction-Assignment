using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_EF
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CustomerName { get; set; }
        public  Customer Customer { get; set; }
        public  OrderDetail Detail { get; set; }
    }
}
