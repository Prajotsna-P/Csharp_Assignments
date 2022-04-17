using System;

public class Operators
{
    public static void Main()
    {
        int x;
        int y;
        Console.WriteLine("Enter the value of x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of y");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the choice");
        Console.WriteLine("Please make your selection");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");

        int ch = Convert.ToInt16(Console.ReadLine());

        switch (ch)
        {
            case 1: Console.WriteLine("Addition of two numbers :" + (x + y));
            break;
            case 2: Console.WriteLine("Subtraction of two numbers :" + (x - y));
            break;
            case 3: Console.WriteLine("Product of two numbers :" + (x * y));
            break;
            case 4: Console.WriteLine("Division of two numbers :" + (x / y));
            break;
            default: Console.WriteLine("Choose only 1 to 4");
            break;
    
        }
        Console.ReadLine();
    }
}