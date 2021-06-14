using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

	public class ConsoleCalculator
    {
		private Calculator _calculator;
		public ConsoleCalculator(Calculator calculator)
        {
			_calculator = calculator;
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
				string number = Console.ReadLine();
				_calculator.MemoryNumber = _calculator.Calculate(_calculator.MemoryNumber, number, operation);
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
	}
}
