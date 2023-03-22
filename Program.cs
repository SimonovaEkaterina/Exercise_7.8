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

			P(Employees);
			Way(Employees);
		}
		/// <summary>
		/// Меню
		/// </summary>
		static void Way(string Employees)
		{
			WriteLine("'1' - Вывести данные на экран. '2' - Заполнить данные и добавить новую записть в конец списка. '3' - Выход");
			string num = ReadLine();
			switch (num)
			{
				case "1":
					Print(Employees);
					break;
				case "2":
					Append(Employees);
					break;
				case "3":

					break;
			}
		}

		/// <summary>
		/// Проверка
		/// </summary>
		static void P(string Employees)
		{
			bool fileExist = File.Exists(Employees);
			if (fileExist)
			{
				Console.WriteLine("Файл, существует.");
			}
			else
			{
				Console.WriteLine("Файл, не существует.");
				File.Create(Employees).Close();
				WriteLine("Файл, Создан.");
			}
		}
		/// <summary>
		/// Запись 
		/// </summary>
		static void Append(string Employees)
		{
			using (StreamWriter sw = new StreamWriter(Employees, true))
			{
				
				
				char key = 'д';
				do
				{
					string text = string.Empty;
					int id = 1;
					Write($"ID:{ id}"); id++;
					//string Id = ReadLine();
					ReadLine();

					DateTime dateTime = DateTime.Now;

					Write("Ф.И.О: ");
					string fio = ReadLine();

					Write("Рост: ");
					int h = int.Parse(ReadLine());

					Write("Дата рождениия(Г.М.Д): ");
					DateTime birthDate = DateTime.Parse(ReadLine());
					int age = CalculateAge(birthDate);

					Write("Возраст: ");
					Console.WriteLine("{0}", age);

					Write("Место рождения: ");
					string spawn = ReadLine();

					text = id + "#" + dateTime + "#" + fio + "#" + h + "#" + birthDate + "#" + age + "#" + spawn;
					sw.WriteLine(text);

					WriteLine("Продолжить - Д/Н"); key = ReadKey(true).KeyChar;
				}
				while (char.ToLower(key) == 'д');
			}
		}
		/// <summary>
		/// Вычисляем возраст по дате
		/// </summary>
		/// <param name="birthDate"></param>
		/// <returns></returns>
		private static int CalculateAge(DateTime birthDate)
		{
			DateTime today = DateTime.Today;

			int age = today.Year - birthDate.Year;
			if (birthDate.AddYears(age) > today)
			{
				age--;
			}
			return age;
		}

		/// <summary>
		/// Четение
		/// </summary>
		static void Print(string Employees)
		{
			using (StreamReader sr = new StreamReader(Employees))
			{
				string Line;
				WriteLine($"{"ID: "}{"Время: "}{"Ф.И.О: "}{"Рост: "}{"Дата рождения: "}{"Возраст: "}{"Место рождения: "} ");

				while ((Line = sr.ReadLine()) != null)
				{
					string[] data = Line.Split('#');
					WriteLine($"{data[0]} {data[1]} {data[2]} {data[3]} {data[4]} {data[5]} {data[6]} ");
				}
			}
			Way(Employees);
		}
	}
}