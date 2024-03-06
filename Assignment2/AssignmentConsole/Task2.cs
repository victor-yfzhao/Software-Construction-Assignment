namespace Assignment2
{
	/// <summary>
	/// 此类为任务2，即对已给数组进行操作
	/// </summary>
	public class Task2
	{
		//私有单例实例
		private static Task2 INSTANCE = new Task2();

		//私有构造函数
		private Task2()
		{
			Console.WriteLine("Building task 2...");
		}

		//获取实例
		public static Task2 getInstance()
		{
			return INSTANCE;
		}

		//运行方法
		public void Run()
		{
			string str = "";
			Console.WriteLine("Please input the length of the array:");

			//输入
			str = Console.ReadLine();
			decimal[] arr = Array.ConvertAll(str.Split(' '), Decimal.Parse);

			//求解
			solve(arr);
		}

		//变量申明为decimal是由于平均值需取小数
		private static void solve(decimal[] input)
		{
			decimal length = input.Length;
			decimal max = input[0],
				min = input[0],
				sum = 0;
			decimal avg;

			//从头至尾遍历数组即可
            for (int i = 0; i < length; i++)
			{
				max = Math.Max(input[i], max);
				min = Math.Min(input[i], min);
				sum += input[i];
			}
			avg = sum / length;
			Console.WriteLine("The maxinum of the array is: \t" + max);
			Console.WriteLine("The mininum of the array is: \t" + min);
			Console.WriteLine("The sum of the array is: \t" + sum);
			Console.WriteLine("The average of the array is: \t" + avg);
		}
	}
}
