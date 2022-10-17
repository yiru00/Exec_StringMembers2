using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			string row = "aLLeN kUO";
			string value=$"{row.Substring(0,1).ToUpper()}{row.Substring(1,5).ToLower()}{row.Substring(6,1).ToUpper()}{row.Substring(7).ToLower()}";
			Console.WriteLine(value);
		}
	}
}
