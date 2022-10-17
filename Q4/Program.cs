using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			string date = "1100225";
			string value = $"{Convert.ToInt32( date.Substring(0, 3)) + 1911}{date.Substring(3)}";
			Console.WriteLine(value);

		}
	}
}
