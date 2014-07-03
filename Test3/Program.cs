//
//  Program.cs
//
//  Author:
//       student <>
//
//  Copyright (c) 2014 student
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace Test3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Введите своё имя");
			string a = Console.ReadLine();
			Console.WriteLine ("Здравствуйте {0}", a);
			Console.WriteLine ("Я ваш личный консольный помошник");
			Console.WriteLine ("Выберете чем из предложенного я могу вам помочь:");
			Console.WriteLine ("---");
			Console.WriteLine ("1 Поиск в итернете");
			Console.WriteLine ("2 Фотографии");
			Console.WriteLine ("3 Музыка");
			Console.WriteLine ("4 Видео");
			Console.WriteLine ("5 Игры");
			int x = int.Parse (Console.ReadLine ());
			if (x == 1)
				Console.WriteLine("Вывыбрали поиск в интернете ");
			if (x == 2)
				Console.WriteLine ("Вы выбрали категорию фотографии");
			if(x==3)
				Console.WriteLine ("Вы выбрали категорию музыка");
			if(x==4)
				Console.WriteLine ("Вы выбрали категорию видео");
			if(x==5)
				Console.WriteLine ("Вы выбрали категорию игры");
			else
			{
				Console.WriteLine ("вы выбрали несуществующий пункт");
			}

		}
	}
}
