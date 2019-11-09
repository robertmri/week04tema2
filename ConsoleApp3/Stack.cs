﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Stack
    {
        public Stack(int x)
        {
            MyStack = new LinkedList<int>();
            MyStack.AddFirst(x);
        }
        private LinkedList<int> MyStack { get; set; }

        internal void Push(int x)
        {
            MyStack.AddFirst(x);
        }
        internal void Pop()
        {
            if (MyStack.Count > 0)
            {
                MyStack.RemoveFirst();
            }
        }

        internal void Print()
        {
            if (MyStack.Count > 0)
            {
                Console.Write($"\nYour current elements in stack are: ");
                foreach (object item in MyStack)
                {
                    Console.Write($"[{item}] ");
                }
            }
            else
            {
                Console.WriteLine("\nNo elements available in stack.");
            }

        }
    }
}
