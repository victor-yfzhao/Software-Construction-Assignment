namespace Assignment2
{
	/// <summary>
	/// 此类为任务1，即求所给数的所有质因数
	/// </summary>
	public class Task1
	{
		//私有单例实例
		private static Task1 INSTANCE = new Task1();

		//私有构造函数
		private Task1()
		{
			Console.WriteLine("Building task 1...");
		}

		//获取实例
		public static Task1 getInstance()
		{
			return INSTANCE;
		}

		//运行
		public void Run()
		{
			string str = "";
			int input = 0;
			Console.WriteLine("Please input a number:");

			//输入并抓取异常
			try
			{
				str = Console.ReadLine();
				input = Int32.Parse(str);
				if (input <= 1) 
					throw new Exception("Invalid Input!");
			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
            }

			//求解方法
			solve(input);
		}

		private static void solve(int input)
		{
			for (int i = 2; i <= input; ) 
			{
				if (input % i == 0) //当该数有此质因数时，除以该因数
				{
					input = input / i;
					Console.Write(i + " ");
				}
				else //当该数无更多此因数时，寻找下一个质因数（方法比较暴力）
					i++;
			}
		}
	}
}
