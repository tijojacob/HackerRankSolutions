using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    internal class Program
    {
        //Last 5 test cases failed due to timeout
        static void Main(string[] args)
        {
            string result = string.Empty;
            List<string> y = new List<string>();
            Stack<string> bckuprslt = new Stack<string>();
            List<string> Operations = new List<string>();
            int noOfOps = 0, i = 0;
            noOfOps = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < noOfOps; i++)
            {
                Operations.Add(Console.ReadLine());
            }
            bckuprslt.Push("");
            Operations.ForEach(x => {
                //Console.WriteLine("x : {0}", x);
                y = x.Trim().Split(' ').ToList();//.ForEach(y =>
                {
                    //Console.WriteLine("y : {0}", y);
                    //Console.WriteLine("y[0] : {0}", y[0]);
                    //Console.WriteLine("y[1] : {0}", y[1]);
                    //Console.WriteLine("y[1] : {0}", y[1]);
                    switch (y[0].ToString())
                    {
                        case "1":
                            result = string.Concat(bckuprslt.Peek(), y[1]);
                            bckuprslt.Push(result);
                            break;
                        case "2":
                            result = result.Remove((result.Count()) - (Convert.ToInt32(y[1])), Convert.ToInt32(y[1]));
                            bckuprslt.Push(result);
                            break;
                        case "3":
                            Console.WriteLine(result[Convert.ToInt32(y[1]) - 1]);
                            break;
                        case "4":
                            bckuprslt.Pop();
                            result = bckuprslt.Peek();
                            break;
                    }
                    //if (y[0].Equals("1"))
                    //{
                    //    result=string.Concat(bckuprslt.Peek(),y[1]);
                    //    bckuprslt.Push(result);
                    //}
                    //else if(y[0].Equals("2"))
                    //{
                    //    result = result.Remove((result.Count()) - (Convert.ToInt32(y[1]) ), Convert.ToInt32(y[1]));
                    //    bckuprslt.Push(result);
                    //}
                    //else if(y[0].Equals("3"))
                    //{
                    //    Console.WriteLine(result[Convert.ToInt32(y[1])-1]);
                    //}
                    //else if(y[0].Equals("4"))
                    //{
                    //    bckuprslt.Pop();
                    //    result = bckuprslt.Peek();
                    //}
                }
                // );

            });
            //Console.WriteLine("result : {0}", result);
            Console.ReadLine();
        }
    }
}
