using System;
using Calculator;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Calculator
{
	public interface ICalculator<TArgument, TOperation>
	{
		TArgument MemoryNumber { get; set; }
		TArgument Plus(TArgument first, TArgument second);
		TArgument Minus(TArgument first, TArgument second);
		TArgument Multiply(TArgument first, TArgument second);
		TArgument Divide(TArgument first, TArgument second);
		TArgument Calculate(TArgument first, String second, TOperation operation);
	}

	public enum CalculatorTypeEnum
	{
		Digit,
		Complex
	}
}