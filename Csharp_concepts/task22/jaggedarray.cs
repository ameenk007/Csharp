using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class jaggedarray
    {
        public static void Main()
        {
            int[][] jarr = new int[3][]
            {
                new int[2] { 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[4] { 5, 6, 7, 8 }
            };
            Console.WriteLine("elements in Jagged array\n");
            for (int i = 0; i < jarr.Length; i++)
            {
                for (int j = 0; j < (jarr[i]).Length; j++)
                {
                    Console.WriteLine("{0} ",jarr[i][j]);
                    Console.WriteLine("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
