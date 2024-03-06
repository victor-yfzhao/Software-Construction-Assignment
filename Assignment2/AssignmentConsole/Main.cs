namespace Assignment2
{
    /// <summary>
    /// 此类作为程序的主入口
    /// 在选择各任务后会获取各任务的实例并运行
    /// 各任务单独封装，并用单例模式实现
    /// （虽然发现直接写静态块也可以？？）
    /// </summary>
    class MainConsole
    {
        static void Main()
        {
            int choice = 0;
            string str = "";
            Console.WriteLine("Please Choose a task to check its validity:");
            Console.WriteLine("1. Decomposition Factor;");
            Console.WriteLine("2. Integer Array;");
            Console.WriteLine("3. Sieve of Eratosthenes;");
            Console.WriteLine("4. Toeplitz Matrix.");
            
            //输入并抓取异常
            try
            {
                str = Console.ReadLine();
                choice = Int32.Parse(str);
                if (choice > 4 || choice < 0) 
                    throw new Exception("Invalid Input!");
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //调用各类实例并运行
            buildTask(choice);
        }

        static void buildTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    Task1.getInstance().Run();
                    break;
                case 2: 
                    Task2.getInstance().Run();
                    break;
                case 3:
                    Task3.getInstance().Run();
                    break;
                case 4:
                    Task4.getInstance().Run();
                    break;
                default:
                    return;
            }
        }
    }
}