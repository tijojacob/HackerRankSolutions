using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        public class Result
        {
            public static string isBalanced(string s)
            {
                int i = 0,strlen= s.Length;
                Stack<string> vs = new Stack<string>();
                for (i = 0; i < strlen; i++)
                {
                    if (s[i].ToString().Equals("{") || s[i].ToString().Equals("(") || s[i].ToString().Equals("["))
                    {
                        vs.Push(s[i].ToString());
                    }
                    else
                    {
                        //if (s[i].ToString().Equals(vs.Peek()))
                        //{
                        //    vs.Pop();
                        //}
                        if(vs.Count==0)
                        {
                            return "NO";
                        }
                        switch (vs.Peek().ToString())
                        {
                            case "(": if (s[i].ToString().Equals(")"))
                                        {
                                            vs.Pop();
                                        }
                                       else
                                        {
                                            vs.Push(s[i].ToString());
                                        }
                                        break;

                            case "{": if (s[i].ToString().Equals("}"))
                                        {
                                            vs.Pop();
                                        }
                                        else
                                        {
                                            vs.Push(s[i].ToString());
                                        }
                                        break;

                            case "[": if (s[i].ToString().Equals("]"))
                                        {
                                            vs.Pop();
                                        }
                                        else
                                        {
                                            vs.Push(s[i].ToString());
                                        }
                                        break;
                            default: vs.Push(s[i].ToString());
                                break;
                        }
                    }
                }
                if (vs.Count()==0)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = Result.isBalanced(s);
                Console.WriteLine(result);
            }            
                
            Console.ReadLine();
        }
    }
}
