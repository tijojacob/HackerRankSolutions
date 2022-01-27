////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace InsertAtSepcificLocationSinglyLinkedList
//{
//    class Program
//    {
//        public class SinglyLinkedListNode
//        {
//            public int data;
//            public SinglyLinkedListNode next;
//            public SinglyLinkedListNode(int dataNode)
//            {
//                this.data = dataNode;
//                this.next = null;
//            }
//        }
//        public class SinglyLinkedList
//        {
//            SinglyLinkedListNode head;
//            SinglyLinkedListNode tail;
//            public SinglyLinkedList()
//            {
//                head = null;
//                tail = null;
//            }

//            public void InsertToSLL(int dataNode)
//            {
//                SinglyLinkedListNode newNode = new SinglyLinkedListNode(dataNode);
//                if (head == null)
//                {
//                    head = newNode;
//                    tail = newNode;
//                }
//                else
//                {
//                    tail.next = newNode;
//                    tail = newNode;
//                }
//            }
//            public void InsertAtLocationSLL(int dataNode,int loc)
//            {
//                int count = 1;
//                SinglyLinkedListNode Node = head;
//                SinglyLinkedListNode prevNode = head;
//                SinglyLinkedListNode newNode = new SinglyLinkedListNode(dataNode);
//                while (Node!=null)
//                {
//                    prevNode = Node;
//                    Node = Node.next;
//                    if(loc==1)
//                    {
//                        newNode.next = head;
//                        head = newNode;
//                        break;
//                    }
//                    else if (count==loc)
//                    {
//                        prevNode.next = newNode;
//                        newNode.next = Node;
//                        break;
//                    }
//                    count++;
//                }
//                if (loc> count)
//                {
//                    Console.WriteLine("No index found");
//                }
//            }
//            public void PrintSLL()
//            {
//                SinglyLinkedListNode node = head;
//                while(node!=null)
//                {
//                    Console.WriteLine(node.data);
//                    node = node.next;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            //SinglyLinkedList SLL = new SinglyLinkedList();
//            //Console.WriteLine("Enter the SLL elements: ");
//            //Console.ReadLine().Trim().Split(' ').ToList().Select(q => Convert.ToInt32(q)).ToList().ForEach((x) =>
//            //{
//            //    SLL.InsertToSLL(x);
//            //});
//            //SLL.PrintSLL();
//            //int newloc = 0,newData=0;
//            //Console.WriteLine("Enter the SLL loc for new element: ");
//            //int.TryParse(Console.ReadLine(), out newloc);
//            //Console.WriteLine("Enter the new SLL data element: ");
//            //int.TryParse(Console.ReadLine(), out newData);
//            //SLL.InsertAtLocationSLL(newData, newloc);
//            //SLL.PrintSLL();
//            //Console.ReadLine();

//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            SinglyLinkedList llist = new SinglyLinkedList();

//            int llistCount = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < llistCount; i++)
//            {
//                int llistItem = Convert.ToInt32(Console.ReadLine());
//                llist.InsertToSLL(llistItem);
//            }

//            int data = Convert.ToInt32(Console.ReadLine());

//            int position = Convert.ToInt32(Console.ReadLine());

//            llist.InsertAtLocationSLL(data, position);

//            llist.PrintSLL();
//            textWriter.WriteLine();

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
