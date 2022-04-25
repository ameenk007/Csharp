using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class Dictionary_Hashtable
    {
        public static void Main()
        {
            dictionary();
            Hashtable();
        }
        public static void dictionary()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("IN", "India");
            dic.Add("US", "United States");
            dic.Add("UK", "United Kingdom");
            dic.Add("UAE", "United Arab Emirates");
            dic.Add("AUS", "Australia");
            Console.WriteLine("Keys in the DIctionary\n");
            var key= new List<string>(dic.Keys);
            foreach(var k in key)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("\n\nValues in the Dictionary\n");
            var value= new List<string>(dic.Values);
            foreach(var v in value)
            {
                Console.WriteLine(v);
            }
        }
        public static void Hashtable()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "Ameen");
            hash.Add("b", "John");
            hash.Add(3, "Joseph");
            hash.Add("c", "Thomas");
            Console.WriteLine("\n\nHastable\n");
            ICollection collection = hash.Keys;
            foreach(var k in collection)
            {
                Console.WriteLine(hash[k]);
            }
            Console.WriteLine("Non-key value: {0}", hash[1]);
        }
    }
}
