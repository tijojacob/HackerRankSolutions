
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new MyLibrary.Customer();

            MyLibrary.MyObject myObject = new MyLibrary.MyObject();
            MySecondLibrary.MyObject myObject2 = new MySecondLibrary.MyObject(10, 10);

            com.squareconnection.mylibrary.MyObject myobject3 = new com.squareconnection.mylibrary.MyObject();
            
            myObject.Calculate(10, 10);

            MyLibrary.ICalculate cal = new MyLibrary.AddCalculate();

            MyLibrary.Supplier supp = new MyLibrary.Supplier();
            supp.SupplierId = 0;

            MyLibrary.otherclass oth = new MyLibrary.otherclass();
            oth.SupplierId = 0;
            //myObject.number1 = 10;
            //myObject.number2 = 5;


            //Console.WriteLine("Number 1 is " + myObject.number1);
            //Console.WriteLine("Number 2 is " + myObject.number2);
            //Console.WriteLine("object 1 property is " + myObject.number3);
            //Console.WriteLine("object 2 property is " + myObject2.number3);

            Console.ReadLine(); 
        }
    }


    
}
