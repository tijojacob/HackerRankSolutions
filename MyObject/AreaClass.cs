using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaClass
{
    public abstract class AreaClass
    {
        // declare method
        // 'Area' as abstract
        abstract public int Area();
    }

    public class Square : AreaClass
    {
        int side = 0;

        // constructor
        public Square(int n)
        {
            side = n;
        }

        // the abstract method
        // 'Area' is overridden here
        public override int Area()
        {
            return side * side;
        }
    }
}
