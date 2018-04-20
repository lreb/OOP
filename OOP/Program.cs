using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Transaction transaction1 = new Transaction(225);
			transaction1.Show();
			Console.Write("\n Enter to exit");
			Console.ReadLine();
		}
	}
}
