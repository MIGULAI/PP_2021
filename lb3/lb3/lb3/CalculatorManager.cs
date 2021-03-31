using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class CalculatorManager
	{
		public CalculatorManager()
		{
			ShowMenu();
		}

		private void ShowMenu()
		{
			Console.WriteLine("Choose your calculator:");
			Console.WriteLine("1) Digit calculator\n2) Complex calculator\n3) Exit");

			try
			{
				var calcType = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				if (calcType == 1)
				{
					var digitCalculator = new DigitConsoleCalculator((DigitCalculator)CalculatorFactory.Create(CalculatorTypeEnum.Digit));
					digitCalculator.ShowCalculator();
				}
				if (calcType == 2)
				{
					var complexCalculator = new ComplexConsoleCalculator((ComplexCalculator)CalculatorFactory.Create(CalculatorTypeEnum.Complex));
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
