using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAtEndOfSinglyLinkedList
{
    class Program
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;
            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }
        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;
            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertSinglyLinkedList(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);
                if(this.head==null)
                {
                    this.head = node;
                    this.tail = node;                    
                }
                else
                {
                    this.tail.next = node;
                    this.tail = node;
                }
            }

            public void PrintSinglyLinkedList(SinglyLinkedListNode head)
            {
                SinglyLinkedListNode node = head;
                while(node!=null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            }
            public void InsertAtEndOfSinglyLinkedList(int nodeData)
            {               
                SinglyLinkedListNode newNode = new SinglyLinkedListNode(nodeData);
                tail.next = newNode;
                tail = newNode;
            }
        }
        static void Main(string[] args)
        {
            SinglyLinkedList lList = new SinglyLinkedList();
            int nodeData = 0;
            Console.WriteLine("Enter the elements for the Singly Linked List: ");            
            Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList().ForEach((v) =>
            {
                lList.InsertSinglyLinkedList(v);
            });
            Console.WriteLine("Elements of the Singly Linked List are as follows: ");
            lList.PrintSinglyLinkedList(lList.head);
            Console.WriteLine("Enter the element for insertion at the End of Singly Linked List: ");
            int.TryParse(Console.ReadLine(), out nodeData);
            lList.InsertAtEndOfSinglyLinkedList(nodeData);
            Console.WriteLine("Elements of the Singly Linked List are as follows: ");
            lList.PrintSinglyLinkedList(lList.head);
            Console.ReadLine();
        }
    }
}
