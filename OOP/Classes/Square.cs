using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interfaces;

namespace OOP.Classes
{
	class Square : IShape
	{
		private double Width;
		//private double Height;
		private double Area;

		public Square(double width)
		{
			this.Width = width;
		}

		void IShape.Area()
		{
			this.Area = this.Width * 4;
		}

		void IShape.Show()
		{
			Console.Write("\n\tThe are of Square is: {0}", this.Area);
		}
	}
}
