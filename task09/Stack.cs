using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Stack<T>
    {
        private T[] items;
        private int top;
        private int size;
        public Stack(int _Size)
        {
            size = _Size;
            items = new T[size];
            top = -1;
        }
        public void Push(T item)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack overflow!");
                return;
            }
            items[++top] = item;
        }
        public T Pop()
        {
            if (top == -1)
                throw new InvalidOperationException("Stack underflow!");
            return items[top--];
        }
        public T Peek()
        {
            if (top == -1)
                throw new InvalidOperationException("Stack is empty!");
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            Console.Write("Stack elements: ");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
