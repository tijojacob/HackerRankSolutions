using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaClass;

namespace OOPS
{
    class Program
    {        
        static void Main(string[] args)
        {
            Square sq = new Square(5);
            Console.WriteLine("\n Area " + sq.Area());
            Console.ReadLine();
        }
    }
}
