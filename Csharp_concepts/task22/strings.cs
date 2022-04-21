using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class strings
    {
        public static void Main()
        {
            string str = "Ameen";
            int length = str.Length;
            Console.WriteLine("string: " + str);
            Console.WriteLine("Length: " + length);
            string str1 = "Muhammed";
            string str2 = "Ameen";
            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("string str1: " + str1);
            Console.WriteLine("string str2: " + str2);
            
            Console.WriteLine("Joined string: " + joinedString);
            string str3 = "C# Programming";
            string str4 = "C# Programming";
            string str5 = "Programiz";
            Boolean result1 = str3.Equals(str4);
            Boolean result2 = str3.Equals(str5);
            Console.WriteLine("string str1 and str2 are equal: " + result1);
            Console.WriteLine("string str1 and str3 are equal: " + result2);
        }
    }
}
