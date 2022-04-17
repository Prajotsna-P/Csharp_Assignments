using System;

public class Class1
{
	public static void Main()
	{
		int a, b, c, d, e;
		Console.WriteLine("Enter the marks of Student1 :");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the marks of Student2 :");
		b = Convert.ToInt32(Console.ReadLine());
     	Console.WriteLine("Enter the marks of Student3 :");
		c = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the marks of Student4 :");
		d = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the marks of Student5 :");
		e = Convert.ToInt32(Console.ReadLine());

		if (a>b && a>c && a>d && a > e)
		{
			Console.WriteLine(a);
		}
		else if(b>a && b>c && b>d && b>e)
        {
			Console.WriteLine(b);
        }
		else if(c>a && c>b && c>d && c>e)
        {
			Console.WriteLine(c);
        }
		else if(d>a && d>b && d>c && d>e)
        {
			Console.WriteLine(d);
        }
		else
        {
			Console.WriteLine(e);
        }
	}
}
