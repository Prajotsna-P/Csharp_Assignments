static void Main()
{
    Stack stack1 = new Stack();
    stack1.Push(1);
    stack1.Push("Employee");
    stack1.Push("13286")
    stack1.Push("Miana");
    stack1.Push("30000");
    foreach (Object obj in stack1)
    {
        Console.WriteLine("different types of data" + ":" + obj);
    }
    stack1.Pop();
    foreach (Object obj in stack1)
    {
        Console.WriteLine("after pop operation" + ":" + obj);
    }

    Console.ReadLine();
}
    }