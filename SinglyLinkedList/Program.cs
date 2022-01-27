using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
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
                if (this.head == null)
                {
                    this.head = node;
                    node.next = null;
                    this.tail = node;
                }
                else
                {
                    this.tail.next = node;
                    this.tail = node;
                }
            }

            public void PrintSinglyLinkedList()
            {
                Console.WriteLine("Elements of the Singly Linked List are : ");
                SinglyLinkedListNode node = head;
                while(node != null)
                {
                    Console.Write("{0}\t", node.data);
                    node = node.next;
                }
            }
        }
        
        static void Main(string[] args)
        {
            SinglyLinkedList lList = new SinglyLinkedList();
            //int noOfItems = 0,i=0;
            //string itemCount = "";
            //Console.WriteLine("No. of elements for the Singly Linked List: ");
            //itemCount=Console.ReadLine();
            //int.TryParse(itemCount, out noOfItems);
            Console.WriteLine("Enter the elements for the Singly Linked List: ");
            //for (i=0;i<noOfItems;i++)
            //{
                Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList().ForEach((v) =>
                {                    
                    lList.InsertSinglyLinkedList(v);
                });
            //}
            lList.PrintSinglyLinkedList();
            Console.ReadLine();
        }
    }
}
