using System;

namespace ArrayStringDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Arrays.Array();
            Strings.String();
            ArrayLists.ArrayList();
            Dictionarys.Dictionary();
           EmpClass empClass = new EmpClass();
            empClass.EmpWageCalculation("tata",200,60,20);


        }
    }
}
