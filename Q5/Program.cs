using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//比對使用者輸入值是否為 "Allen" 不拘大小寫
			string name = "Allen";
			Console.Write("請輸入姓名");
			string input=Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("未輸入");
				return;
			}

			if (input.ToLower() == name.ToLower())
			{
				Console.WriteLine("正確");
			}
			else
			{
				Console.WriteLine("錯誤");
			}
		}
	}
}
