using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interfaces;

namespace OOP.Classes
{
	class Transaction : ITransactions
	{
		private Guid Code;
		private double Amount;

		public Transaction(double amount)
		{
			this.Code = Guid.NewGuid();
			this.Amount = amount;
		}

		public double GetAmount()
		{
			return this.Amount;
		}

		public void Print()
		{
			throw new NotImplementedException();
		}

		public void Show()
		{
			Console.Write("\n\tCode: {0} \n\t Amount: ${1}", this.Code, this.Amount);
		}
	}
}
