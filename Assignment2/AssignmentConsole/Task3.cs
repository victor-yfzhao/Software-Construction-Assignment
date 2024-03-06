namespace Assignment2
{
	/// <summary>
	/// 此类为任务3，即埃氏筛
	/// </summary>
	public class Task3
	{
		//私有单例实例
		private static Task3 INSTANCE = new Task3();

		//私有构造函数
		private Task3()
		{
			Console.WriteLine("Building task 3...");
		}

		//获取实例
		public static Task3 getInstance()
		{
			return INSTANCE;
		}

		//运行
		public void Run()
		{
			bool[] sieve = new bool[101]; //遍历标签
			int[] prime = new int[101]; //记录素数
			int cnt = 0;//计数
			for (int i = 2; i < 101; i++)
			{
				if (!sieve[i]) //未遍历则为素数
				{
					prime[cnt] = i;
					sieve[i] = true;
					cnt++;
					for (int j = i; j < 101; j += i) //排除范围内所有该素数的倍数
					{
						sieve[j] = true;
					}
				}
			}

			//输出
			for (int i = 0; i < cnt; i++)
			{
				Console.Write(prime[i] + " ");
			}
		}
	}
}
