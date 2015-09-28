using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string[] _table = { "Иван", "Гошо", "Гергана" };

			// Анкета на таблица
			Console.WriteLine ("Име");
			Console.WriteLine ("=======");
			// Тяло на таблицата

			for (int i=0; i < _table.Length; i++)

				//Код за цикъла

				Console.WriteLine (_table[i]);
		}
	}
}
