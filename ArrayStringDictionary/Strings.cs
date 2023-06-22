using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStringDictionary
{
    public class Strings
    {
        public static void String() 
        {

            Random rnd = new Random();
            var v = rnd.Next(0, 5);
            
            String[] Array  = new String[5];
            Array[0] = "ram";
            Array[1] = "raj";
            Array[2] = "ramesh";
            Array[3] = "ganesh";
            Array[4] = "kiran";

            Console.WriteLine(Array[v]);


        }
    }
}
