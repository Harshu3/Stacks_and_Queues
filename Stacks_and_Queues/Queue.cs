using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    public class Queue
    {
        Node top = null;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is added to queue", newNode.data);
            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = newNode;
                Console.WriteLine("{0} is added to queue", newNode.data);
            }
        }

        public void Dequeue()
        {
            while (top != null)
            {
                Node temp = top.next;
                Console.WriteLine($"Deleting element: {top.data}");
                top = top.next;
                Display();
            }
        }

        public void Display()
        {
            Node temp = top;

            if (top == null)
            {
                Console.WriteLine("No elements are present in queue");
                return;
            }
            
            Console.WriteLine("\nDisplaying queue elements");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
