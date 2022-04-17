using System;

public class Class1
{
	public static void Swap(ref double x ,ref  double y)
	{
		
		double temp;
		temp = x;
		x = y;
		y = temp;
	}
	public static void Main()
    {
		double x = Convert.ToDouble(Console.ReadLine());
		double y = Convert.ToDouble(Console.ReadLine());
		Swap(ref x,ref y);
		Console.WriteLine("After Swapping :{0} ,{1}",x,y);
    }
}
