using System;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Problem!");
            Console.WriteLine("Program to create simple stack");
            Stack st = new Stack();
            st.Push(70);
            st.Push(30);
            st.Push(56);
            st.Display();
        }
    }
}