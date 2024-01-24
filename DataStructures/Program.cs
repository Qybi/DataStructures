using DataStructures.DataStructures;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueTest(10);
        }

        static void LinkedListTest()
        {
            LinkedList list = new LinkedList();
            list.InsertNode(0);

            list.PrintList();
            Console.WriteLine("--------------");
            list.InsertNode(2);
            list.InsertNode(3);
            list.InsertNode(4);
            list.InsertNode(5);
            list.PrintList();
            Console.WriteLine("--------------");
            list.DeleteNode(3);
            list.PrintList();
        }

        static void StackTest(int size)
        {
            DataStructures.Stack stack = new Stack(size);
            stack.push(0);
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.printStack();
            Console.WriteLine("--------------");
            Console.WriteLine("item " + stack.pop() + " has been removed");
            Console.WriteLine("--------------");
            Console.WriteLine("item at the top is " + stack.peek());
            Console.WriteLine("--------------");
            stack.printStack();
        }

        static void QueueTest(int size)
        {
            DataStructures.Queue queue = new Queue(10);
            queue.Add(0);
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);
            queue.Add(6);
            queue.Add(7);
            queue.Add(8);
            queue.Add(9);
            queue.Add(10);
            queue.PrintQueue();
            Console.WriteLine("--------------");
            queue.Remove();
            queue.Remove(); 
            queue.Remove();
            queue.Remove();
            queue.PrintQueue();
            Console.WriteLine("--------------");
            queue.Add(10);
            queue.Add(11);
            queue.Add(12);
            queue.PrintQueue();
            Console.WriteLine("--------------");
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.PrintQueue();

        }
    }
}
