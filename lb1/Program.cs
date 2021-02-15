using System;
using Calculator;
using System.Numerics;

namespace lb1
{
    public class DigitConsoleCalculator
    {
	    private readonly DigitCalculator _calculator;

	    public DigitConsoleCalculator()
	    {
	    	_calculator = new DigitCalculator();
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
			    double number = Convert.ToDouble(Console.ReadLine());
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



    class Program
    {
	    static void Main(string[] args)
	    {
	    	DigitConsoleCalculator digitConsoleCalculator = new DigitConsoleCalculator();
	    	digitConsoleCalculator.ShowCalculator();
	    }
    }
}
