using System;
using Calculator;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Calculator{
    public interface ICalculator<TArgument, TOperation> 
    {
	    TArgument MemoryNumber { get; set; }
	    TArgument Plus(TArgument first, TArgument second);
	    TArgument Minus(TArgument first, TArgument second);
	    TArgument Multiply(TArgument first, TArgument second);
	    TArgument Divide(TArgument first, TArgument second);
	    TArgument Calculate(TArgument first, String second, TOperation operation);
    }

    public class DigitCalculator : ICalculator<double, string>
    {
        public double MemoryNumber { get; set; }
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
        public double Calculate(double first, string secondStr, string operation)
        {
			double second = StringToArg(secondStr);
	        switch (operation)
	        {
		    case "+":
		    	return Plus(first, second);
		    case "-":
		    	return Minus(first, second);
		    case "*":
		    	return Multiply(first, second);
		    case "/":
		    	return Divide(first, second);
		    default:
		    	throw new Exception("No such operation!");
	        }
        }

		private double StringToArg(String arg){
			return Convert.ToDouble(arg);
		}
    }

    public class ComplexCalculator : ICalculator<Complex, string>
    {
	    internal ComplexCalculator()
	    {
		    double Memory = 0;
	    }
	    public Complex MemoryNumber { get; set; }
	    public Complex Plus(Complex first, Complex second)
	    {
		    return first + second;
	    }
	public Complex Minus(Complex first, Complex second)
	{
		return first - second;
	}
	public Complex Multiply(Complex first, Complex second)
	{
		return first * second;
	}
	public Complex Divide(Complex first, Complex second)
	{
		if (second == 0)
			throw new DivideByZeroException();
		return first / second;
	}
	public Complex Calculate(Complex first, String secondStr, string operation)
	{
		Complex second = StringToArg(secondStr);
		switch (operation)
		{
			case "+":
				return Plus(first, second);
			case "-":
				return Minus(first, second);
			case "*":
				return Multiply(first, second);
			case "/":
				return Divide(first, second);
			default:
				throw new Exception("No such operation!");
		}
	}
	private Complex StringToArg(String arg){
			Regex rg = new Regex(@"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)");
				
			MatchCollection matched = rg.Matches(arg);
			Console.WriteLine("r :" + matched[0].Value + " m :" + matched[1].Value );
			string realStr = matched[0].Value;
			string invStr = matched[1].Value;
			double real = Double.Parse(realStr);
			double inv = Double.Parse(invStr);
			Complex nowEnted = new Complex(real , inv );
			return nowEnted;
		}
}



}