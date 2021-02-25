using System;
using System.Numerics;

namespace Calculator{
    public interface ICalculator<TArgument, in TOperation> where TArgument : struct
    {
	    TArgument MemoryNumber { get; set; }
	    TArgument Plus(TArgument first, TArgument second);
	    TArgument Minus(TArgument first, TArgument second);
	    TArgument Multiply(TArgument first, TArgument second);
	    TArgument Divide(TArgument first, TArgument second);
	    TArgument Calculate(TArgument first, TArgument second, TOperation operation);
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
        public double Calculate(double first, double second, string operation)
        {
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
	public Complex Calculate(Complex first, Complex second, string operation)
	{
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
}



}