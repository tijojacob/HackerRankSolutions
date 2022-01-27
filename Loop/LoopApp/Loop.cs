using System;

namespace LoopApp
{
    class Loop
    {
        static string GetNumber()
        {
            Console.WriteLine("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter another number: ");
            string num2 = Console.ReadLine();
            Int64 numb1 = 0, numb2 = 0;
            Int64.TryParse(num1, out numb1);
            Int64.TryParse(num2, out numb2);
            if (numb1 > numb2)
            {
                Console.WriteLine("The number " + numb1 + " is grater");
            }
            else if (numb2 > numb1)
            {
                Console.WriteLine("The number " + numb2 + " is grater");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }

            Console.WriteLine("Enter Q/q to quit else press any key to continue ");
            string exitval = Console.ReadLine();
            return exitval;
        }
        static void Main(string[] args)
        {
            string exitval = "";
            //The same can be acquired with Switch and Break statements;
            while (exitval.ToUpper() != "Q")
            {
                exitval = GetNumber();
            }
        }
    }
}
