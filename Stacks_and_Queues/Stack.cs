using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    public class Stack
    {
        public Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is added to stack", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is added to stack", newNode.data);
            }
        }

        public void Display()
        {
            if (top == null)
                Console.WriteLine("No elements are present in stack");
            else
            {
                Node temp = top;
                Console.WriteLine("\nDisplaying stack elements");

                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
