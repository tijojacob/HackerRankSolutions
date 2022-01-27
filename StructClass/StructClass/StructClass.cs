using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructClass
{
    class StructClass
    {
        static void Multiply(ClassDefinition cls, StructDefinition str)
        {
            cls.intVar = cls.intVar * 2;
            str.intVar = str.intVar * 2;

            Console.WriteLine("Class Multiply : "+cls.intVar);
            Console.WriteLine("Str Multiple : " + str.intVar);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] strArray = new string[5];

            intArray[0] = 1;
            intArray[1] = 2;

            int[] intArray2 = new int[] { 1, 2, 3, 4 };

            string[] strArray2 = new string[] { "One", "Two", "Three" };

            int[,] intMultiAray = new int[2, 2];
            intMultiAray[0,0] = 1;

            int[,] intMultiAry2 = new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] intMultiAry3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            ClassDefinition cls = new ClassDefinition();
            cls.intVar = 123;
            cls.strVar = "Class Variable";
            cls.enumVal = EnumDefinition.ClassDef;
            //cls.Address.=
            ClassDefinition2 Address = new ClassDefinition2();
            Address.test = "";

            StructDefinition str;
            str.intVar = 456;
            str.strVar = "Struct Variable";
            str.enumVal = EnumDefinition.StructDef;

            Console.WriteLine("1)Class Variable, INT value" + cls.intVar + "\nString Value : " + cls.strVar+"\nEnum : "+cls.enumVal);
            Console.WriteLine("1)Struct Variable, INT value" + str.intVar + "\nString Value : " + str.strVar+"\nEnum : "+str.enumVal);

            Multiply(cls, str);

            Console.WriteLine("2)Class Variable, INT value" + cls.intVar + "\nString Value : " + cls.strVar + "\nEnum : " + cls.enumVal);
            Console.WriteLine("2)Struct Variable, INT value" + str.intVar + "\nString Value : " + str.strVar + "\nEnum : " + str.enumVal);
            Console.ReadLine();

            List<string> listVar = new List<string>();
            listVar.Add("Hai");
            listVar.Insert(0, "Default");
            listVar.Sort();
            Console.WriteLine("List Variable : ");
            foreach(var a in listVar)
            {
                Console.Write("\n"+a);
            }
            Console.ReadLine();

            Dictionary<int, string> dictVar = new Dictionary<int, string>();
            dictVar.Add(1, "One");
            dictVar.Add(2, "Two");
            dictVar.Add(3, "Three");

            Console.WriteLine("\n\nDictionary Values : ");
            foreach(var item in dictVar)
            {
                Console.WriteLine("Dictionary Key :" + item.Key + "\t Dictionary Value :" + item.Value);
            }
            Console.ReadLine();

            List<ClassDefinition> classlst = new List<ClassDefinition>();
            ClassDefinition clsvar2 = new ClassDefinition();
            clsvar2.intVar = 11;
            clsvar2.strVar = "LINQ";
            ClassDefinition clsvar3 = new ClassDefinition() { intVar = 22, strVar = "LNIQ2" };
            classlst.Add(clsvar2);
            classlst.Add(clsvar3);

            List<ClassDefinition> classlst2 = new List<ClassDefinition>();
            classlst2 = (from x in classlst
                       where x.enumVal == EnumDefinition.ClassDef
                       select x).ToList();

            classlst2 = classlst.Where(p => p.enumVal == EnumDefinition.ClassDef).ToList();

            Console.WriteLine("Results Count :" + classlst2.Count());
            Console.ReadLine();

        }

        class ClassDefinition 
        {
            public int intVar = 0;
            public string strVar = "";
            public EnumDefinition enumVal;
            protected string test = "";
            //public ClassDefinition2 Address = new ClassDefinition2();
        }

        class ClassDefinition2 : ClassDefinition
        {
            public int postal = 0;
            public string aDdress = "";
            //public EnumDefinition enumVal;
        }

        struct StructDefinition
        {
            public int intVar ;
            public string strVar ;
            public EnumDefinition enumVal;
        }

        enum EnumDefinition
        {
            ClassDef,
            StructDef
        }

    }
}
