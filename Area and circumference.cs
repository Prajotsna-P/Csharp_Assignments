using System;

public class Class1
{
	public static void Calculation(ref double r)
	{
		double area;
		double circum;
		area = Math.PI * r * r;
		circum = 2 * Math.PI * r;
		Console.WriteLine("Area is :{0}", area);
		Console.WriteLine("Circumfrence is : {0}", circum);
	}
	public static void Main()
    {
		double r = Convert.ToDouble(Console.ReadLine());
		Calculation(ref r);
    }
	
}
