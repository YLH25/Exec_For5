using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* 用for 迴圈呈現以下訊息
			++++1
			+++22
			++333
			+4444
			55555
			*/

			for (int i = 1; i <= 5; i++)
			{
				for (int j = 5; j>i; j--)
				{
					Console.Write('+');
				}
				for (int n = 5-i; n < 5;n++ )
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
		}
	}
}
