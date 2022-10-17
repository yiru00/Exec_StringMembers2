using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//隱藏手機的資訊 呈現 0935****46
			Console.Write("輸入手機號碼");
			string phoneNum = Console.ReadLine();

			if (string.IsNullOrEmpty(phoneNum)||phoneNum.Length!=10)
			{
				Console.WriteLine("輸入格式錯誤");
				return;
			}

			string value = $"{phoneNum.Substring(0, 4)}{new string('*', 4)}{phoneNum.Substring(8)}";
			Console.WriteLine(value);

		}
	}
}
