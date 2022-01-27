using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDuplicate_valueNodesFromaSortedLinkedList
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
                    Console.WriteLine();
                }
            }
        }


        /*
         * Complete the 'removeDuplicates' function below.
         *
         * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
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

        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode tempNode1 = llist;
            SinglyLinkedListNode prevNode1 = llist;
            SinglyLinkedListNode loopNode1 = llist;
            int smallest = llist.data, temp = llist.data;
            for (tempNode1 = llist; tempNode1 != null; tempNode1 = tempNode1.next)
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
            prevNode1 = llist;
            tempNode1 = llist;
            loopNode1 = llist;
            //for (loopNode1 = llist; loopNode1 != null; loopNode1 = loopNode1.next)
            //{
            //    tempNode1 = loopNode1;
                while (tempNode1 != null)
                {
                    prevNode1 = tempNode1;
                    tempNode1 = tempNode1.next;
                    if (tempNode1 != null)
                    {
                        Console.WriteLine("prevNode1.data : {0}, tempNode1.data : {1}", prevNode1.data, tempNode1.data);
                        if (prevNode1.data == tempNode1.data)
                        {
                            tempNode1 = tempNode1.next;
                            if (tempNode1 != null)
                            {
                                Console.WriteLine("Changed Next : {0}", tempNode1.data);
                            }
                            prevNode1.next = tempNode1;
                        tempNode1 = llist;
                        }
                    }
                }
            //}
            return llist;
        }



        static void Main(string[] args)
        {            

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = removeDuplicates(llist.head);

                PrintSinglyLinkedList(llist1, " ");
                
            }

            Console.ReadLine();
        }
    }
}
