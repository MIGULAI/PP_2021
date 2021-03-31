using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
	public class ComplexCalculator : Calculator
	{
		internal ComplexCalculator()
		{
			MemoryNumber = "0+0i";
		}
		public string MemoryNumber { get; set; }
		public String Plus(Complex first, Complex second)
		{
			Complex result = first + second;
			String resultStr = ToString(result);
			return resultStr;
		}
		public String Minus(Complex first, Complex second)
		{
			Complex result = first - second;
			String resultStr = ToString(result);
			return resultStr;
		}
		public String Multiply(Complex first, Complex second)
		{
			Complex result = first * second;
			String resultStr = ToString(result);
			return resultStr;
		}
		public String Divide(Complex first, Complex second)
		{
			if (second == 0)
				throw new DivideByZeroException();
			Complex result = first / second;
			String resultStr = ToString(result);
			return resultStr;
		}

		private String ToString(Complex complex)
        {
            if (complex.Imaginary >= 0)
            {
				return (String.Format("{0}+{1}i", complex.Real, complex.Imaginary));
			}
            else
            {
				return (String.Format("{0}{1}i", complex.Real, complex.Imaginary));
			}
			
        }

		private Complex StringToArg(String arg)
		{
			Regex rg = new Regex(@"([-+]?\d+\,?\d*|[-+]?\d*\,?\d+)");

			MatchCollection matched = rg.Matches(arg);
			string realStr = matched[0].Value;
			string invStr = matched[1].Value;
			double real = Double.Parse(realStr);
			double inv = Double.Parse(invStr);
			Complex nowEnted = new Complex(real, inv);
			return nowEnted;
		}

		public override string Calculate(string firstStr, String secondStr, string operation)
		{
			Complex second = StringToArg(secondStr);
			Complex first = StringToArg(firstStr);
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
