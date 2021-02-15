using System;

namespace lb1
{
    class Program
    {
        static void Main(string[] args)
{
	MemoryNumber = 0;
	ShowCalculator();
}
public static double MemoryNumber { get; set; }
public static double Plus(double first, double second)
{
	return first + second;
}
public static double Minus(double first, double second)
{
	return first - second;
}
public static double Multiply(double first, double second)
{
	return first * second;
}
public static double Divide(double first, double second)
{
	if (second == 0)
		throw new DivideByZeroException();
	return first / second;
}
public static double Calculate(double first, double second, string operation)
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
public static void ShowCalculator()
{
	Console.WriteLine(MemoryNumber);
	string operation = Console.ReadLine();
	if (operation.Equals("exit"))
	{
		Environment.Exit(0);
	}
	try
	{
		double number = Convert.ToDouble(Console.ReadLine());
		MemoryNumber = Calculate(MemoryNumber, number, operation);
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
