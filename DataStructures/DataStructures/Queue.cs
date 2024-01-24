using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    internal class Queue
    {
        public int[] elements;
        public int size;
        public int front;
        public int rear;

        public Queue(int size)
        {
            front = rear = -1;
            this.size = size;
            elements = new int[size];
        }

        public void Add(int element)
        {
            if (isFull()) return;
            else if (front == -1) // first element of the queue
            {
                front = rear = 0;
                elements[rear] = element;
            }
            else if (rear == size - 1 && front != 0)
            { 
                // se il puntatore di testa non è 0 e il puntatore di coda è
                // arrivato lala fine dell'array, rear ricomincia dallo 0 dell'array
                rear = 0;
                elements[rear] = element;
            } else
            {
                rear++;
                elements[rear] = element;
            }
        }
        public int Remove()
        {
            if (isEmpty()) return -1;
            int value = elements[front];
            elements[front] = -1;
            if (front == rear) // caso in cui ci sia solamente un elemento in coda
            {
                front = rear = -1;
            }
            else if (front == size - 1) // caso in cui stia facendo il dequeue del primo elemento della coda, a che fisicamete è l'ultimo nell'array
                front = 0;
            else
                front++;
            return value;
        }
        public void Clear()
        {
            elements = [];
        }
        public int Front()
        {
            return elements[front];
        }
        public int Rear()
        {
            return elements[rear];
        }

        public bool isEmpty()
        {
            return front == -1;
        }
        public bool isFull()
        {
            // (front == 0 && rear == size - 1) è la condizione nella quale la coda è stata riempita solo da enqueue/Add
            // (front - 1) % (size - 1) permette di verificare che il front sia praticamente rear+1
            // in una coda circolare (guardare riferimento al disegno su g4g)
            if ((front == 0 && rear == size - 1) 
                || (rear == (front - 1) % (size - 1)))
                return true;
            return false;
        }
        public void PrintQueue()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            if (rear >= front) 
            {
                for (int i = front; i <= rear; i++)
                    Console.WriteLine($"Queue position {i} | value {elements[i]}");
            }
            else
            {
                for (int i = front; i < size; i++)
                    Console.WriteLine($"Queue position {i} | value {elements[i]}");
                for (int i = 0; i < rear; i++)
                    Console.WriteLine($"Queue position {i} | value {elements[i]}");
            }
        }
    }
}
