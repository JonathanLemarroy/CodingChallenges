using System;
					
public class Program
{
	public static double Integral(double b, double m, double n){
		return (Math.Pow(n, b + 1) - Math.Pow(m, b + 1));
	}
	
	public static void Main()
	{
		Console.WriteLine(Integral(0, 2, 5));
        Console.WriteLine(Integral(2, 4, 7));
        Console.WriteLine(Integral(5, 9, 3));
	}
}