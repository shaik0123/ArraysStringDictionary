using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStringDictionary
{
    public class Dictionarys
    {
        public static void Dictionary()
        {
            Random rnd = new Random();
            var v = rnd.Next(0, 5);

            Dictionary<String, int> contact = new Dictionary<string, int>();
            contact.Add("mohan", 12);
            contact["x"] = 12;

            foreach (var key in contact) {
                Console.WriteLine("key : "+key.Key+  "    value : "+key.Value);
               // Console.WriteLine(key);
            }

            Console.WriteLine("Dictionary output");
            Console.ReadLine();


            


        }
    }
}
