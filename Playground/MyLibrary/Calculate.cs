using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class AddCalculate : MyLibrary.ICalculate
    {
        public int PerformCal(int n1, int n2){
            return n1 + n2;
        }
    }

    public class SubtractCalculate : MyLibrary.ICalculate
    {
        public int PerformCal(int n1, int n2)
        {
            return n1 - n2;
        }
    }

    public class MultiplyCalculate : MyLibrary.ICalculate
    {
        public int PerformCal(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
