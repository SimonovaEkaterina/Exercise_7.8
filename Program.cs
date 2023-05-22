using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.PerformanceData;
using System.Reflection;

namespace Exercise_7._8
{
	internal class Program
	{
		static void Main(string[] args)
		//Справочник " Сотрудники "

		{
			string Employees = @"Employees.txt";
			Repository  r = new Repository();
			r.P(Employees);

			WriteLine("'1' - Вывести данные на экран. '2' - Заполнить данные и добавить новую записть в конец списка.");
			byte num = byte.Parse(ReadLine());

			if (num == 1)
			{
				r.Print(Employees);
				
				ReadKey();
			}
			else if (num == 2)
			{
				r.Append(Employees);
			}
			else 
			{
				ReadKey();
			}
		}
	}
}