using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Src
{
    public enum DetailType
    {
        ItemName,
        CustomerName,
        ItemValue,
        Id
    }
    
    public class OrderDetails
    {
        public string itemName { get; set; }
        public string customerName { get; set; }
        public int itemValue { get; set; }

        public string ItemName { get
            {
                return itemName;
            }
        }

        public OrderDetails() 
        {
            itemName = "";
            customerName = "";
            itemValue = 0;
        }

        public OrderDetails(string _itemName, string _customerName, int _itemValue)
        {
            if (_itemName == null || _customerName == null) throw new ArgumentNullException();
            if (_itemValue < 0) throw new Exception("Value cannot be a negtive number");
            itemName = _itemName;
            customerName = _customerName;
            itemValue = _itemValue;
        }
/*
        public override string ToString()
        {
            return "Item Name: \t" + itemName +
                "\nCustomer Name: \t" + customerName +
                "\nItem Value: \t" + itemValue + "\n";
        }
*/
        public void ModifyOrder(DetailType type, string modify)
        {
            if (modify == null) throw new ArgumentNullException();
            switch (type)
            {
                case DetailType.ItemName:
                    itemName = modify; break;
                case DetailType.CustomerName:
                    customerName = modify; break;
                case DetailType.ItemValue:
                    itemValue = Convert.ToInt32(modify); break;
                default:
                    throw new Exception("There is no such type!");
            }
        }

        public string GetItemName()
        {
            return itemName;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public int GetItemValue()
        {
            return itemValue;
        }
    }
}
