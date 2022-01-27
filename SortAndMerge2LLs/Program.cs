using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndMerge2LLs
{
    class Program
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.WriteLine(sep);
                }
            }
        }
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            int smallest, temp;
            SinglyLinkedListNode tempNode1 = head1;
            SinglyLinkedListNode prevNode1 = head1;
            SinglyLinkedListNode startNode = (head1 == null ? head2 : head1);
            if (head1 != null)
            {
                while (tempNode1 != null)
                {
                    prevNode1 = tempNode1;
                    tempNode1 = tempNode1.next;
                }
                if (head2 != null)
                {
                    prevNode1.next = head2;
                }
                startNode = head1;
            }
            else
            {
                if (head2 != null)
                {
                    startNode = head2;
                }
            }

            for (tempNode1 = startNode; tempNode1 != null; tempNode1 = tempNode1.next)
            {
                prevNode1 = tempNode1;
                smallest = tempNode1.data;
                while (prevNode1 != null)
                {
                    if (smallest > prevNode1.data)
                    {
                        temp = prevNode1.data;
                        prevNode1.data = smallest;
                        smallest = temp;
                        //Console.WriteLine("smallest : " + smallest);
                        //Console.WriteLine("prevNode1.data :" + prevNode1.data);
                        //Console.WriteLine("temp :" + temp);
                    }
                    prevNode1 = prevNode1.next;
                }
                tempNode1.data = smallest;
            }
            return startNode;
        }
        static void Main(string[] args)
        {            

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

                PrintSinglyLinkedList(llist3, " ");
                Console.ReadLine();
            }            
        }
    }
}
