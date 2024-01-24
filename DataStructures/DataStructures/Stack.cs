using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    internal class Stack
    {
        private int[] elements;
        private int top;
        private int size;
        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            this.size = size;
        }

        public void push(int value)
        {
            if (isFull()) return;
            else elements[++top] = value;
        }
        public int pop()
        {
            if (isEmpty()) return -1;
            else
            {
                return elements[top--];
            }
        }
        public int peek()
        {
            if (isEmpty()) return -1;
            else return elements[top];
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            else return false;
        }
        public bool isFull()
        {
            if (top == size - 1) return true;
            else return false;
        }
        public void printStack()
        {
            if (size == 0) return;
            
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine($"position: {i} | value: {elements[i]}");    
            }
        }
    }
}
