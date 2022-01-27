using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessing
{
    class Program
    {
        public static long minTime(List<int> files, int numCores, int limit)
        {
            long pCount = 0, sum = 0;
            //files.Sort();
            Console.WriteLine("numCores : {0}", numCores);
            Console.WriteLine("limit : {0}", limit);
            Console.WriteLine("pCount : {0}", pCount);
            Console.WriteLine("FIle Count : {0}", files.Count());
            files.ForEach(x => {
                Console.WriteLine(x);
                // Console.WriteLine("numCores : {0}",numCores);
                // Console.WriteLine("limit : {0}",limit);
                // Console.WriteLine("pCount : {0}",pCount);
                if (x % numCores == 0 && pCount < limit)
                {
                    sum += Math.Abs((x / numCores));
                    pCount++;
                }
                else
                {
                    sum += Math.Abs(x);
                }
                Console.WriteLine("Sum : {0}", sum);
            });

            return sum;
        }
        static void Main(string[] args)
        {

            int filesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> files = new List<int>();

            for (int i = 0; i < filesCount; i++)
            {
                int filesItem = Convert.ToInt32(Console.ReadLine().Trim());
                files.Add(filesItem);
            }

            int numCores = Convert.ToInt32(Console.ReadLine().Trim());

            int limit = Convert.ToInt32(Console.ReadLine().Trim());

            long result = minTime(files, numCores, limit);

            Console.WriteLine(result);
            Console.ReadLine();
           
        }
    }
}
