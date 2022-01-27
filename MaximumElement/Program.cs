using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {        
        public class SingleListNode
        {
            public int data;
            public SingleListNode next;
            public SingleListNode prev;
            public SingleListNode(int data)
            {
                this.data = data;
                this.next = null;
                this.prev = null;
            }
        }

        public class newStack
        {
            public SingleListNode top;
            int topElement = 0;
            public newStack()
            {
                top = null;
            }
            public void push(int data)
            {
                SingleListNode node = new SingleListNode(data);
                node.data = data;
                node.next = null;
                node.prev = null;
                if (top == null)
                {
                    top = node;
                }
                else
                {
                    top.next = node;
                    node.prev = top;
                    top = node;
                }
            }
            public int pop()
            {
                topElement = top.data;
                top = top.prev;
                return topElement;
            }
            public void pop(int data)
            {
                if (top.data == data)
                {
                    top = top.prev;
                }
            }
            public int getMax()
            {
                if (top == null)
                {
                    return -22;
                }
                else
                {
                    return top.data;
                }
            }
        }        

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> res = new List<int>();
            int options = 0;
            newStack ns = new newStack();
            newStack maxs = new newStack();
            for (int i = 0; i < n; i++)
            {
                string[] opsItem = Console.ReadLine().Split();
                options = Convert.ToInt32(opsItem[0]);
                if (options == 1)
                {
                    options = Convert.ToInt32(opsItem[1]);
                    if (maxs.getMax() == -22 || (maxs.getMax() <= options))
                    {
                        maxs.push(options);
                    }
                    ns.push(options);
                }
                else if (options == 2)
                {
                    maxs.pop(ns.pop());
                }
                else if (options == 3)
                {
                    res.Add(maxs.getMax());
                }
            }

            Console.WriteLine(String.Join("\n", res));
            Console.ReadLine();
        }
    }
}
