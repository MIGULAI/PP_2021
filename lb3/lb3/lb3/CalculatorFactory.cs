using System;

namespace Calculator
{
    class CalculatorFactory
    {
		public static object Create(CalculatorTypeEnum type)
		{
			switch (type)
			{
				case CalculatorTypeEnum.Digit:
					return new DigitCalculator();
				case CalculatorTypeEnum.Complex:
					return new ComplexCalculator();
				default:
					throw new NotImplementedException();
			}
		}
	}
}
