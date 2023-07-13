using System;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Problem!");
            Console.WriteLine("Program to dequeue elements from queue");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
        }
    }
}