using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interfaces;

namespace OOP.Classes
{
	class Rectangle : IShape
	{
		private double Width;
		private double Height;
		private double Area;

		public Rectangle(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		void IShape.Area()
		{
			this.Area = this.Width * this.Height;
		}

		void IShape.Show()
		{
			Console.Write("\n\tThe are of Rectangle is: {0}", this.Area);
		}
	}
}
