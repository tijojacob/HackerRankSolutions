using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualStacks
{
    class Program
    {
        class Result
        {
            /*
             * Complete the 'equalStacks' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY h1
             *  2. INTEGER_ARRAY h2
             *  3. INTEGER_ARRAY h3
             */            
            public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
            {                
                int s1 = 0, s2 = 0, s3 = 0;                
                s1 = h1.Sum();
                s2 = h2.Sum();
                s3 = h3.Sum();
                while (s1!=s2 || s1!=s3 || s1!=s3)
                {
                    
                    if (s1 > s2)
                    {
                        if (s1 > s3)
                        {
                            s1 -= h1[0];
                            h1.RemoveAt(0);
                        }
                        else if (s3 > s2)
                        {
                            s3 -= h3[0];
                            h3.RemoveAt(0);
                        }
                        else
                        {
                            s2 -= h2[0];
                            h2.RemoveAt(0);
                        }
                    }
                    else
                    {
                        if (s2 > s3)
                        {
                            s2 -= h2[0];
                            h2.RemoveAt(0);
                        }
                        else
                        {
                            s3 -= h3[0];
                            h3.RemoveAt(0);
                        }
                    }                    
                }
                return s1;
            }
        }

        public static void Main(string[] args)
        {
            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int n1 = Convert.ToInt32(firstMultipleInput[0]);

            //int n2 = Convert.ToInt32(firstMultipleInput[1]);

            //int n3 = Convert.ToInt32(firstMultipleInput[2]);

            List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

            List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

            List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

            int result = Result.equalStacks(h1, h2, h3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

