using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Solution
    {
        class Result
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
                public SingleListNode max;
                int topElement = 0;
                public newStack()
                {
                    top = null;
                }
                public void push(int data)
                {
                    SingleListNode node = new SingleListNode(data);                    
                    node.data = data;                                        
                    if(top != null)
                    {
                        top.next = node;
                        node.prev = top;
                        top = node;
                    }
                    else
                    {
                        top = node;
                    }
                    if(max!=null)
                    {
                        if(max.data<=data)
                        {
                            SingleListNode maxNode = new SingleListNode(data);
                            max.next = maxNode;
                            maxNode.prev = max;
                            max = maxNode;
                        }
                    }
                    else
                    {
                        SingleListNode maxNode = new SingleListNode(data);
                        max = maxNode;
                    }                                                          
                }
                public int pop()
                {
                    topElement = top.data;
                    //Console.WriteLine("pop : {0}", top.data);
                    top = top.prev;
                    if (top != null)
                    {
                        top.next = null;
                    }
                    if (topElement==max.data)
                    {
                        max = max.prev;
                        if (max != null)
                        {
                            max.next = null;
                        }
                    }
                    return topElement;
                }                
                public int getMax()
                {
                    //Console.WriteLine("getMax : {0}",top.data);
                    if (top != null)
                    {
                        return max.data;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }


        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int options = 0;
            List<int> res=new List<int>();
            Result.newStack ns = new Result.newStack();
            for (int i = 0; i < n; i++)
            {
                string[] opsItem = Console.ReadLine().Split();
                options = Convert.ToInt32(opsItem[0]);
                if (options==1)
                {                                    
                    ns.push(Convert.ToInt32(opsItem[1]));
                }
                else if(options==2)
                {
                    ns.pop();
                }
                else if (options==3)
                {
                    res.Add(ns.getMax());
                }
            }


            Console.WriteLine(String.Join("\n", res));

            Console.ReadLine();
        }
    }
}

