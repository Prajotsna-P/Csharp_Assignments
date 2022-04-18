using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionInCsharp
{
    class Stack
    {
        int[] stack;
        int sp;

        public Stack(int size)
        {
            stack = new int[size];
            sp = 0;
        }
        public bool Push(int item)
        {
            if (sp < stack.Length)
            {
                stack[sp] = item;
                sp++;
                return true; //Pushed successfully;
            }
            else
                throw new Exception("stack full");//stack full
        }

        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            else
                throw new Exception("stack empty");
        }
        static void Main(string[] args)
        {
            Stack s = new Stack(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            int num;
            try
            {
                num = s.Pop();
            }
            catch (CustomPush_Pop ce)
            {
                Console.WriteLine(ce.Message);
            }
        }
        public class CustomPush_Pop : Exception
        {
            public CustomPush_Pop(string msg) : base(msg)
            {

            }
        }
    }
}