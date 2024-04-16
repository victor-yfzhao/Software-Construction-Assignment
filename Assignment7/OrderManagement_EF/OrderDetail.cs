using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_EF
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public  List<KeyValuePair<Item, int>> Items { get; set; }
        public int TotalCount { get; set; }
        public int TotalPrice { get; set; }
    }
}
