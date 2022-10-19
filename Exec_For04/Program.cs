using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 呈現 1 ~ 20, 若是 3 的倍數顯示 foo, 若是 5 的倍數顯示 bar, 若是 15 的倍數顯示 foobar, 其餘顯示數值
			int start = 1;
			int end = 20;

			for (int i = start; i <= end; i++)
			{
				if (i % 5 == 0 && i % 3 == 0)
				{
					Console.WriteLine("foo bar foobar");

				}
				else if (i % 15 == 0)
				{
					Console.WriteLine("foobar");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("bar");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("foo");
				}
				else
				{
					Console.WriteLine(i);
				}
			}



		}
	}
}
