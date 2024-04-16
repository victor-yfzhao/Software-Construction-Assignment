using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace OrderManagement_EF
{
    enum OperateType
    {
        _,
        Customer,
        Item,
        Order
    }

    internal class Program
    {
        private static OrderManagement orderManagement = OrderManagement.management;
        
        public static void Main()
        {
            while (true)
            {
                OperateType choice;

                Console.WriteLine(
                    "Please choose a type to operate with:\n" +
                    "1. Customer\n" +
                    "2. Item\n" +
                    "3. Order\n" +
                    "4. Exit");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 4) return;
                    if (input < 1 || input > 4) 
                        throw new Exception("Invalid input!!\n\n");
                    if (input == 1 || input == 2)
                        throw new NotImplementedException();
                    choice = (OperateType)input;


                    Console.WriteLine(
                        "\nPlease choose an operation:\n" +
                        "1. Create a(an) " + choice + "\n" +
                        "2. Modify a(an) " + choice +"\n" +
                        "3. Search " + choice + "(s)\n" +
                        "4. Delete a(an) " + choice + "(s)\n" +
                        "5. Exit");
                    int operate = Convert.ToInt32(Console.ReadLine());
                    switch (operate)
                    {
                        case 1:
                            CreateMethod();
                            break;
                        case 2:
                            ModifyMethod();
                            break;
                        case 3:
                            SearchMethod();
                            break;
                        case 4:
                            DeleteMethod();
                            break;
                        case 5:
                            return;
                        default: throw new Exception("Invalid input!!\n\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void CreateMethod()
        {
            Console.WriteLine("\nPlease input Customer's Name:");
            var customer = new Customer()
            {
                CustomerName = Console.ReadLine(),
            };
            var detail = new OrderDetail()
            {
                Items = new List<KeyValuePair<Item, int>>()
            };
            do
            {
                Console.WriteLine("Please input Item's Name:");
                string item_name = Console.ReadLine();
                Console.WriteLine("Please input Item's Price:");
                int item_price = Convert.ToInt32(Console.ReadLine());
                var item = new Item()
                {
                    ItemName = item_name,
                    Price = item_price
                };
                Console.WriteLine("Please input the Number of this Item:");
                int item_count = Convert.ToInt32(Console.ReadLine());

                detail.Items.Add(new KeyValuePair<Item, int>(item, item_count));
                detail.TotalCount += item_count;
                detail.TotalPrice += item_price * item_count;

                Console.WriteLine("Wanna keep adding item(s)? (y/n)");
            } while (Console.ReadLine() == "y");
            int id = orderManagement.CreateOrder(detail, customer);
            Console.WriteLine("Successfully create Order " + id + "\n");
        }

        private static void ModifyMethod()
        {
            throw new NotImplementedException();
        }

        private static void SearchMethod()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMethod()
        {
            throw new NotImplementedException();
        }
    }
}
