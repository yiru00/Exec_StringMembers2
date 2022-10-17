using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//比對使用者輸入值是否為 "Allen", 區分大小寫
			string name = "Allen";
			Console.Write("請輸入姓名");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("未輸入");
				return;
			}
			string inputName = $"{input.Substring(0, 1).ToUpper()}{input.Substring(1).ToLower()}";
			if (input==name)
			{
				Console.WriteLine("正確");
			}
			else if (inputName==name)
			{
				Console.WriteLine("請注意大小寫");
			}
			else
			{
				Console.WriteLine("不正確");
			}

		}
	}
}
