using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayStringDictionary
{
    public class ArrayLists
    {
        public static void ArrayList()
        {
            Random rnd = new Random();
            var v = rnd.Next(0, 5);

            ArrayList List = new ArrayList();
            List.Add(1);
            List.Add("string");
            List.Add(9.0);
            List.Add('d');
            List.Add(7842556575);

            Console.WriteLine(List[v]);


        }
    }
}
