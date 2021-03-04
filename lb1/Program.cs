using System;
using Calculator;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace lb1
{
    public class DigitConsoleCalculator
    {
	    private ICalculator<TArgument, in TOperation> where TArgument : struct _calculator;

	    public DigitConsoleCalculator(ICalculator _calc)
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

	public class ComplexConsoleCalculator 
    {
	    private readonly ComplexCalculator _calculator;

	    public ComplexConsoleCalculator()
	    {
	    	_calculator = new ComplexCalculator();
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
				Regex rg = new Regex(@"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)");
				string inp = Console.ReadLine();
				
				MatchCollection matched = rg.Matches(inp);
				Console.WriteLine("r :" + matched[0].Value + " m :" + matched[1].Value );
				string realStr = matched[0].Value;
				string invStr = matched[1].Value;
				double real = Double.Parse(realStr);
				double inv = Double.Parse(invStr);
				Complex nowEnted = new Complex(real , inv );
			    _calculator.MemoryNumber = _calculator.Calculate(_calculator.MemoryNumber, nowEnted, operation);
			    //Console.Clear();
		    }
		    catch (Exception exception)
		    {
			    //Console.Clear();
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
			ComplexCalculator complexCalculator = new ComplexCalculator();
			//complexConsoleCalculator.ShowCalculator(); 

	    	DigitConsoleCalculator digitConsoleCalculator = new DigitConsoleCalculator(complexCalculator);
	    	digitConsoleCalculator.ShowCalculator();
	    }
    }
}
