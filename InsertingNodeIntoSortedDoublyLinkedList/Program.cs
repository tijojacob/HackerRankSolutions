using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingNodeIntoSortedDoublyLinkedList
{
    class Program
    {
        public class DoubleLinkedListNode
        {
            public int data;
            public DoubleLinkedListNode next;
            public DoubleLinkedListNode prev;
            public DoubleLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        public class DoubleLinkedList
        {
            public DoubleLinkedListNode head;
            public DoubleLinkedListNode tail;
            public DoubleLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InserttoDoublyLinkedList(int nodeData)
            {
                DoubleLinkedListNode node = new DoubleLinkedListNode(nodeData);
                if (this.head==null)
                {
                    head = node;
                    tail = node;
                    head.prev = null;
                    head.next = null;
                    tail.prev = null;
                    tail.next = null;
                }
                else
                {
                    node.prev = tail;
                    node.next = null;
                    tail.next = node;
                    tail = node;
                }

            }
            public void PrintDoublyLinkedList(DoubleLinkedListNode head)
            {
                DoubleLinkedListNode node = head;
                while(node!=null)
                {
                    Console.Write("{0} \t", node.data);
                    node = node.next;
                }

            }
            public DoubleLinkedListNode SortedInsert (DoubleLinkedListNode head, int data)
            {
                DoubleLinkedListNode temp1= new DoubleLinkedListNode(data);
                DoubleLinkedListNode prevNode;
                int smallest = head.data,swap=0;
                temp1.prev = null;
                temp1.next = head;
                head = temp1;

                for (temp1 = head; temp1 != null; temp1 = temp1.next)
                {
                    prevNode = temp1;
                    //smallest = temp1.data;
                    while(prevNode != null)
                    {
                        if(temp1.data > prevNode.data)
                        {
                            swap = prevNode.data;
                            prevNode.data = temp1.data;
                            temp1.data = swap;
                        }
                        prevNode = prevNode.next;
                    }
                    //temp1.data = smallest;
                }
                return head;
            }

        }

        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            string insertedValue;
            Console.WriteLine("Enter the elements for the Doubly Linked List: ");           
            Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList().ForEach((v) =>
            {
                doubleLinkedList.InserttoDoublyLinkedList(v);
            });
            Console.WriteLine("Enter the elements for Sorted Insert: ");
            insertedValue=Console.ReadLine();            
            doubleLinkedList.PrintDoublyLinkedList(doubleLinkedList.SortedInsert(doubleLinkedList.head, Convert.ToInt32(insertedValue)));
            Console.ReadLine();
        }
    }
}
