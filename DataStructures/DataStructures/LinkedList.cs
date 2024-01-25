using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    internal class LinkedList
    {
        public LLNode head;
        public void InsertNode(int data)
        {
            if (head == null)
            {
                head = new LLNode() { data = data, next = null };
                return;
            }
            LLNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new LLNode() { data = data, next = null };
        }
        public void PrintList()
        {
            int counter = 0;
            LLNode temp = new LLNode() { data = head.data, next = head.next };
            while (temp != null)
            {
                Console.WriteLine($"Node {counter} has value {temp.data}");
                counter++;
                temp = temp.next;
            }
        }
        public void DeleteNode(int position)
        {
            LLNode temp1 = head;
            LLNode temp2 = null;
            int length = 0;

            // check if list is empty
            if (head == null) return;

            // calculate list length
            while (temp1 != null)
            {
                temp1 = temp1.next;
                length++;
            }

            // check if position is valid
            if (position > length || position < 0) return;

            // reset temp1 to head
            temp1 = head;

            // removing head
            if (position == 0)
            {
                head = temp1.next;
                temp1 = null;
                return;
            }

            // here i track the current node and the previous node
            // traverse to node
            while (position > 0)
            {
                temp2 = temp1;
                temp1 = temp1.next;

                position--;
            }

            // here temp1 is the node to be deleted and temp2 is the previous node
            // so i change the next pointer of the previous node to the next pointer of the node to be deleted
            temp2.next = temp1.next;

            // delete node
            temp1 = null;
        }
    }

    internal class LLNode
    {
        public int data;
        public LLNode? next;
    }
}
