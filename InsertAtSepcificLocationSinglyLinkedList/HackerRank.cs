using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

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
            //textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                //textWriter.Write(sep);
            }
        }
    }

    /*
     * Complete the 'insertNodeAtPosition' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. INTEGER_SINGLY_LINKED_LIST llist
     *  2. INTEGER data
     *  3. INTEGER position
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
    //public class SinglyLinkedListNode1
    //{
    //    public int data;
    //    public SinglyLinkedListNode1 next;

    //    public SinglyLinkedListNode1(int nodeData)
    //    {
    //        this.data = nodeData;
    //        this.next = null;
    //    }
    //}

    //public class SinglyLinkedList1
    //{
    //    public SinglyLinkedListNode1 head;
    //    public SinglyLinkedListNode1 tail;

    //    public SinglyLinkedList1()
    //    {
    //        this.head = null;
    //        this.tail = null;
    //    }

    //    public void InsertNode(int nodeData)
    //    {
    //        SinglyLinkedListNode1 node = new SinglyLinkedListNode1(nodeData);

    //        if (this.head == null)
    //        {
    //            this.head = node;
    //        }
    //        else
    //        {
    //            this.tail.next = node;
    //        }

    //        this.tail = node;
    //    }
    //}
    static SinglyLinkedListNode nsertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
    {
        int count = 1;
        SinglyLinkedListNode Node = llist;
        SinglyLinkedListNode prevNode = llist;
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
        while (Node != null)
        {
            prevNode = Node;
            Node = Node.next;
            if (position == 1)
            {
                newNode.next = llist;
                return newNode;
            }
            else if (count == position)
            {
                prevNode.next = newNode;
                newNode.next = Node;
                return llist;
            }
            count++;
        }
        if (position > count)
        {
            Console.WriteLine("No index found");
        }
        return llist;
    }



    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++)
        {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int data = Convert.ToInt32(Console.ReadLine());

        int position = Convert.ToInt32(Console.ReadLine());

        SinglyLinkedListNode llist_head = nsertNodeAtPosition(llist.head, data, position);

        PrintSinglyLinkedList(llist_head, " ");
        //textWriter.WriteLine();

        //textWriter.Flush();
        //textWriter.Close();
    }
}
