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
			string a =Console.ReadLine();
			Console.WriteLine ("Здравствуйте {0}", a);
			Console.WriteLine ("Я ваш личный консольный помошник");
			Console.WriteLine ("Выберете чем из предложенного я могу вам помочь");
			Console.WriteLine ("----");
			Console.WriteLine ("Поиск в итернете");
			Console.WriteLine ("Калькулятор");
			Console.WriteLine ("Игры");

		}
	}
}
