using System;
using Calculator;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace lb3
{

	/*public class ConsoleCalculator<TArgument> where TArgument : struct
	{
		private ICalculator<TArgument, string> _calculator;
		public ConsoleCalculator(ICalculator<TArgument, string> _Calc)
		{
			_calculator = _Calc;
		}

		public void ShowCalculator()
		{
			Console.WriteLine(_calculator.MemoryNumber);
			string operation = Console.ReadLine();
			if (operation.Equals("exit"))
			{
				Environment.Exit(0);
			}
			try
			{
				String num = Console.ReadLine();
				_calculator.MemoryNumber = _calculator.Calculate(_calculator.MemoryNumber, num, operation);
				Console.Clear();
			}
			catch (Exception exception)
			{
				Console.Clear();
				Console.WriteLine(exception.Message);
			}
			finally
			{
				ShowCalculator();
			}
		}
	}*/
	class Program
    {

		static void Main(string[] args)
		{
			new CalculatorManager();
		}
	}
}
