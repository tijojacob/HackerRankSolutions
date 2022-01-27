using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaOfARectangleInaHistogram
{
    class Result
    {


        /*
         * Complete the 'largestRectangle' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts INTEGER_ARRAY h as parameter.
         */
        //Referred GeeksforGeeks
        public static long largestRectangle(List<int> h)
        {
            int n= h.Count;
            Stack<int> stCount = new Stack<int>();

            int max_area = 0; 
            int tp; 
            int area_with_top; 

            
            int i = 0;
            while (i < n)
            {
                
                if (stCount.Count == 0 || h[stCount.Peek()] <= h[i])
                {
                    stCount.Push(i++);
                }

                
                else
                {
                    tp = stCount.Peek(); 
                    stCount.Pop(); 

                    
                    area_with_top = h[tp] *
                                   (stCount.Count == 0 ? i : i - stCount.Peek() - 1);

                    if (max_area < area_with_top)
                    {
                        max_area = area_with_top;
                    }
                }
            }

            while (stCount.Count > 0)
            {
                tp = stCount.Peek();
                stCount.Pop();
                area_with_top = h[tp] *
                               (stCount.Count == 0 ? i : i - stCount.Peek() - 1);

                if (max_area < area_with_top)
                {
                    max_area = area_with_top;
                }
            }

            return max_area;

        }

        class Solution
        {
            public static void Main(string[] args)
            {

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

                long result = Result.largestRectangle(h);

                Console.WriteLine(result);

                Console.ReadLine();
            }
        }

    }
}
