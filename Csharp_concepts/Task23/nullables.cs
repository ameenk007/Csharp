using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class nullables
    {
        public static void Main()
        {
            int? num = null;
            string? str = null;
            int? num1 = 7;
            int? a = null;
            int? b = 5;
            int? f = 3;
            int? g = 4;
            int? c;
            c = a ?? b;
            int? d = g ?? c;
            int? e = f ?? g;
            Console.WriteLine("Null value of datatype int stored in num: {0}\nHas value: {1}\n\n", num, num.HasValue);
            Console.WriteLine("Null value of datatype int stored in num: {0}\nHas value: {1}\n\n", num1, num1.HasValue);
            Console.WriteLine($"Null value inside datatype string: {str}");
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
