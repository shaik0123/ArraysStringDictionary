using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStringDictionary
{
    public class Arrays
    {
        public static void Array()
        {
            Random rnd = new Random();
            var v = rnd.Next(0, 5);
            //int[] array = {1,2,3,4,5};
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine(array[v]);
        }
    }
}
