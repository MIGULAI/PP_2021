using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class DigitCalculator : Calculator
	{
		internal DigitCalculator()
		{
			MemoryNumber = "0";
		}
		public string MemoryNumber { get; set; }
		public double Plus(double first, double second)
		{
			return first + second;
		}
		public double Minus(double first, double second)
		{
			return first - second;
		}
		public double Multiply(double first, double second)
		{
			return first * second;
		}
		public double Divide(double first, double second)
		{
			if (second == 0)
				throw new DivideByZeroException();
			return first / second;
		}
		public override string Calculate(string first, string second, string operation)
		{
			double firstArg = Convert.ToDouble(first);
			double secondArg = Convert.ToDouble(second);
			switch (operation)
			{
				case "+":
					return Plus(firstArg, secondArg).ToString();
				case "-":
					return Minus(firstArg, secondArg).ToString();
				case "*":
					return Multiply(firstArg, secondArg).ToString();
				case "/":
					return Divide(firstArg, secondArg).ToString();
				default:
					throw new Exception("No such operation!");
			}
		}
	}
}
