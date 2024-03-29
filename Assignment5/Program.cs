using Assignment5.Src;

namespace Assignment5
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int choice;
                OrderManagement management = OrderManagement.GetInstance();

                Console.WriteLine(
                    "Please choose an operation:\n" + 
                    "1. Create an order\n" + 
                    "2. Delete an order\n" + 
                    "3. Modify an order\n" + 
                    "4. Search an order\n" + 
                    "5. Exit");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 5)
                        throw new Exception("Invalid Input!");

                    switch (choice)
                    {
                        case 1:
                            string[] details= new string [3];
                            Console.WriteLine("Please input the item's name:");
                            details[0] = Console.ReadLine();
                            Console.WriteLine("Please input the Customer's name:");
                            details[1] = Console.ReadLine();
                            Console.WriteLine("Please input the item's value:");
                            details[2] = Console.ReadLine();
                            Order createOrder = management.CreateOrder(details);
                            Console.WriteLine("Create Successfully! The order's details is as follow:");
                            Console.WriteLine(createOrder.ToString());
                            break;
                        case 2:
                            int deleteId;
                            Console.WriteLine("Please input the order's id that you wish to delete:");
                            deleteId = Convert.ToInt32(Console.ReadLine());
                            management.DeleteOrder(deleteId);
                            Console.WriteLine("Delete Successfully!");
                            break;
                        case 3:
                            int modifyId;
                            Console.WriteLine("Please input the order's id:");
                            modifyId = Convert.ToInt32(Console.ReadLine());
                            Order modifyOrder = management.SearchOrderById(modifyId);
                            DetailType detailType;
                            string detail;
                            Console.WriteLine(
                                "Please choose the data type:\n" + 
                                "1. Item's Name\n" +
                                "2. Customer's Name\n" +
                                "3. Item's Price");
                            detailType = (DetailType)Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Please input what you want to modify with:");
                            detail = Console.ReadLine();
                            management.ModifyOrder(modifyOrder, detailType, detail);
                            Console.WriteLine("Modify Successfully! The order's details after modified is as follow:");
                            Console.WriteLine(modifyOrder.ToString());
                            break;
                        case 4:
                            DetailType type;
                            Console.WriteLine(
                                "Please choose the data type:\n" +
                                "1. Item's Name\n" +
                                "2. Customer's Name\n" +
                                "3. Item's Price\n" +
                                "4. Id");
                            type = (DetailType)Convert.ToInt32(Console.ReadLine()) - 1;
                            switch (type)
                            {
                                case DetailType.ItemName:
                                case DetailType.CustomerName:
                                case DetailType.ItemValue:
                                    string search;
                                    Console.WriteLine("Please input the data you want to search:");
                                    search = Console.ReadLine();
                                    Order [] query = management.SearchOrderByDetail(type, search);
                                    foreach (var item in query)
                                    {
                                        Console.WriteLine(item.ToString());
                                    }
                                    break;
                                case DetailType.Id:
                                    int searchId;
                                    Console.WriteLine("Please input the id you want to search:");
                                    searchId = Convert.ToInt32(Console.ReadLine());
                                    Order searchOrder = management.SearchOrderById(searchId);
                                    Console.WriteLine(searchOrder.ToString());
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 5:
                            return;
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}