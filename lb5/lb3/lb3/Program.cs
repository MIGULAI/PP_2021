using System;
using Calculator;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace lb3
{
	class Program
    {

		static void Main(string[] args)
		{
			var instance = CalculatorManager.getInstance();
			instance.ShowMenu();
		}
	}
}
