using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string[,] _table = {
			
			    {"Иван",    "Георгиев", "19" },
				{"Васил",   "Иванов",   "24" },
				{"Милен",   "Йорданов", "30" },
				{"Цветан",  "Борисов",  "28" },
				{"Гергана", "Василева", "16" },
				{"Ивана",   "Христова", "21" }
			};

			// Анкета на таблица
			Console.WriteLine ("Име".PadRight(12)+"Фамилия".PadRight(12)+"Години".PadRight(12) );
			Console.WriteLine ("=================================");

			// Тяло на таблицата

			for (int i = 0; i < _table.Length/3; i++) 
			{
				for (int j = 0; j < 3; j++) 
				{
					
					Console.Write ( _table [i, j].PadRight (12) );
				}
				Console.WriteLine ("\n");


			}
			Console.WriteLine ("=================================");
	
		}
	}
}  
