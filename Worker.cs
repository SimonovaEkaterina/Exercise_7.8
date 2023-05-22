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
	struct Worker
	{
		/// <summary>
		/// Номер записи
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Дата записи
		/// </summary>
		public DateTime DateTime { get; private set; }

		/// <summary>
		/// ФИО Сотрудника
		/// </summary>
		public string Fio { get; set; }

		/// <summary>
		/// Возраст
		/// </summary>
		public string Age { get; set; }

		/// <summary>
		/// Рост
		/// </summary>
		public int H { get; set; }

		/// <summary>
		/// Дата Рождения
		/// </summary>
		public string Data { get; set; }

		/// <summary>
		/// Место рождения
		/// </summary>
		public string Spawn { get; set; }

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
			this.Id = id;
			this.DateTime = gateTime;
			this.Fio = fio;
			this.Age = age;
			this.H = h;
			this.Data = data;
			this.Spawn = swawn;

		}
	}
}
