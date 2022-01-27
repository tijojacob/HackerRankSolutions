using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverUsingSingleLinkedList
{
    class Solution
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


        /*
         * Complete the 'reversePrint' function below.
         *
         * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
         */

        /*
         * For your reference:
         *
         * SinglyLinkedListNode
         * {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */

        static void reversePrint(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode currNode = llist;
            SinglyLinkedListNode prevNode = null;
            SinglyLinkedListNode nxtNode = null;

            int count = 0;
            while (currNode != null)
            {
                count++;
                nxtNode = currNode.next;
                if (count == 1)
                {
                    currNode.next = null;
                }
                else
                {
                    currNode.next = prevNode;
                }
                prevNode = currNode;
                currNode = nxtNode;
                //this.head = null;
            }
            PrintSLL(prevNode);
        }

        static void PrintSLL(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode node = llist;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }


        static void Main(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                reversePrint(llist.head);
            }
            Console.ReadLine();
        }
    }

}
