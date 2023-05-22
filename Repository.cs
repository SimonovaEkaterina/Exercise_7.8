using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7._8
{
	struct Repository
	{
		private Worker[] worker;// Основной масив для хранения данных
		public string employees; // Путь к файлу с данными
		int index;// Текущий элемент для добавления в worker
		string[] Line;//Масив, для заполнени заголовков полей -> Print

		public Repository(string Employees)
		{
			this.employees = Employees; // Сохранение пути к файлу
			this.index = 0; // Текущая позиция для добавления в файл 
			this.worker = new Worker[6]; // Массив сотрудника 
			this.Line = new string[6]; // Массив заголовка 
		}

		public void Resize (bool  Flag)
		{
			if (Flag)
			{
				Array.Resize(ref this.worker, this.worker.Length * 2);			
			}
		}
		public void Add ( )
		{ 
		
		}
		public int Count { get { return this.index; } }
		
		/// <summary>
		/// Чтение
		/// </summary>
		/// <param name="Employees"></param>
		/// <returns></returns>
		public void Print (string Employees)
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
		}

		/// <summary>
		/// Запись 
		/// </summary>
		public void Append(string Employees)
		{
			using (StreamWriter sw = new StreamWriter(Employees, true))
			{
				char key = '2';
				do
				{
					string text = string.Empty;

					Write("ID: ");
					string id = ReadLine();

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

					WriteLine("Продолжить - 2"); key = ReadKey(true).KeyChar;
				}
				while (char.ToLower(key) == '2');
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
		/// Проверка
		/// </summary>
		public void P(string Employees)
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
		//public Worker GetWorkerById(int id)
		//{
		//	// происходит чтение из файла, возвращается Worker
		//	// с запрашиваемым ID
		//}

		//public void DeleteWorker(int id)
		//{
		//	// считывается файл, находится нужный Worker
		//	// происходит запись в файл всех Worker,
		//	// кроме удаляемого
		//}

		//public void AddWorker(Worker worker)
		//{
		//	// присваиваем worker уникальный ID,
		//	// дописываем нового worker в файл
		//}

		//public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
		//{
		//	// здесь происходит чтение из файла
		//	// и возврат массива считанных экземпляров
		//	// фильтрация нужных записей
		//	Worker.OrderBy(w => w.FIO);
		//	Worker.OrderBy(w => w.Id);

	}
}
