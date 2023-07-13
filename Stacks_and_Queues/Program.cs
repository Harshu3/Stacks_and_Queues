using System;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Problem!");
            Console.WriteLine("Program to Peek and Pop from stack till it is empty");
            Stack st = new Stack();
            st.Push(70);
            st.Push(30);
            st.Push(56);
            st.Display();
            Console.WriteLine("\nRemoving all elements till stack is empty\n");
            st.IsEmpty();
            st.Display();
        }
    }
}