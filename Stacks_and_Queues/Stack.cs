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

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                Console.WriteLine("{0} is the topmost element", top.data);
                return top.data;
            }
        }

        public void Pop()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                int delData = Peek();
                top = top.next;
                Console.WriteLine("{0} is deleted from stack\n", delData);
            }
        }

        public void IsEmpty()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            while (top != null)
                Pop();
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
            }
        }
    }
}
