using System;
using static System.Console;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7._8
{
	struct Worker
	{
		/// <summary>
		/// Номер записи
		/// </summary>
		public int id { get; private set; }

		/// <summary>
		/// Дата записи
		/// </summary>
		public DateTime dateTime { get; private set; }

		/// <summary>
		/// ФИО Сотрудника
		/// </summary>
		public string fio { get; set; }

		/// <summary>
		/// Возраст
		/// </summary>
		public string age { get; set; }

		/// <summary>
		/// Рост
		/// </summary>
		public int h { get; set; }

		/// <summary>
		/// Дата Рождения
		/// </summary>
		public string data { get; set; }

		/// <summary>
		/// Место рождения
		/// </summary>
		public string spawn { get; set; }

		/// <summary>
		/// Создание сотрудника
		/// </summary>
		/// <param name="id"></param>
		/// <param name="gateTime"></param>
		/// <param name="fio"></param>
		/// <param name="age"></param>
		/// <param name="h"></param>
		/// <param name="data"></param>
		/// <param name="swawn"></param>
		public Worker(int id, DateTime gateTime, string fio, string age, int h, string data, string swawn)
		{
			this.id = id;
			this.dateTime = gateTime;
			this.fio = fio;
			this.age = age;
			this.h = h;
			this.data = data;
			this.spawn = swawn;

		}



	}

}
