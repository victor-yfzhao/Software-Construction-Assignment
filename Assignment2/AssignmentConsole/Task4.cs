namespace Assignment2
{
	/// <summary>
	/// 此类为任务4，即矩阵判断
	/// </summary>
	public class Task4
	{
		//私有单例实例
		private static Task4 INSTANCE = new Task4();

		//私有构造函数
		private Task4()
		{
			Console.WriteLine("Building task 4...");
		}

		//获取实例
		public static Task4 getInstance()
		{
			return INSTANCE;
		}

		//运行
		public void Run()
		{
			int c = 0, r = 0;
			string str = "";

			//输入行数和列数，包括处理异常
			try
			{
				Console.WriteLine("Please input the number of column(s):");
				str = Console.ReadLine();
				c = Int32.Parse(str);
                Console.WriteLine("Please input the number of row(s):");
                str = Console.ReadLine();
                r = Int32.Parse(str);
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			//矩阵输入
			int[][] matrix = new int [c][];
            Console.WriteLine("Please input the matrix:");
            for (int i = 0; i < c; i++)
			{
                str = Console.ReadLine();
				matrix[i] = Array.ConvertAll(str.Split(' '), Int32.Parse);
            }

			if (solve(c, r, matrix)) //求解
				Console.WriteLine("True!");
			else 
				Console.WriteLine("False!");
		}

		private static bool solve(int c, int r, int[][] matrix)
		{
			int cur; //当前第一个数

			//第一列比较
			for(int i = c - 1; i > 0; i--)
			{
				cur = matrix[i][0];
				for(int j = 1; j < c - i && j < r; j++)
				{
					if (matrix[i + j][j] != cur)
						return false;
				}
			}

			//第一行比较
            for (int i = 0; i < r; i++)
            {
                cur = matrix[0][i];
                for (int j = 1; j < r - i && j < c; j++)
                {
                    if (matrix[j][i + j] != cur)
                        return false;
                }
            }

			//都通过则符合要求
			return true;
        }
	}
}
