using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;
using OOP.Interfaces;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Transaction transaction1 = new Transaction(225);
			transaction1.Show();
			IShape square = new Square(2);
			square.Area();
			square.Show();
			IShape rectangle = new Rectangle(2, 5.5);
			rectangle.Area();
			rectangle.Show();

			Console.Write("\n\t Enter to exit");
			Console.ReadLine();
		}
	}
}
