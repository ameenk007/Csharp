using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class paramsarray
    {
        public static int add(params int[] a)
        {
            int sum = 0;
            Console.WriteLine("elements in params array:\n");
            foreach (int i in a)
            {
                sum = sum + i;
                Console.WriteLine("\t{0}\t", i);
            }
            return sum;
        }
        static void Main()
        {
            int sum;
            sum = paramsarray.add(1, 2, 3);
            Console.WriteLine("Sum from 1st call\t{0}\n", sum);
            sum =paramsarray.add(1, 3, 2, 4, 5,6,7,8,9);
            Console.WriteLine("Sum from 2nd call\t{0}\n", sum);
        }
    }
}
    