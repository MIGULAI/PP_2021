using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class CalculatorManager
	{
		private static CalculatorManager _instance;
		public static CalculatorManager getInstance()
		{
			if (_instance == null)
			{
				_instance = new CalculatorManager();
			}
			return _instance;
		}
		public void ShowMenu()
		{
			Console.WriteLine("Choose your calculator:");
			Console.WriteLine("1) Digit calculator\n2) Complex calculator\n3) Exit");

			try
			{
				var calcType = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				if (calcType == 1)
				{
					var digitCalculator = new ConsoleCalculator((DigitCalculator)CalculatorFactory.Create(CalculatorTypeEnum.Digit));
					digitCalculator.ShowCalculator();
				}
				if (calcType == 2)
				{
					var complexCalculator = new ConsoleCalculator((ComplexCalculator)CalculatorFactory.Create(CalculatorTypeEnum.Complex));
					complexCalculator.ShowCalculator();
				}
				if (calcType == 3)
				{
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
				Console.Clear();
				ShowMenu();
			}
		}
	}
}
