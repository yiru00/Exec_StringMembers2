using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算兩數之和,並只呈現小數二位數
			Console.WriteLine("請輸入數字1");
			string input1=Console.ReadLine();
			double num1 = Convert.ToDouble(input1);

			Console.WriteLine("請輸入數字2");
			string input2 = Console.ReadLine();
			double num2 = Convert.ToDouble(input2);
			double sum=num1 + num2;

			string value=sum.ToString();
			int endIndex = value.IndexOf('.')+2;
			string row=value.Substring(0, endIndex+1);
			Console.WriteLine($"兩數相加等於{row}");
		}
	}
}
