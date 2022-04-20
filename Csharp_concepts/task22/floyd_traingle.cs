using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class floyd_triangle
    {
        public static void Main()
        {
            int row, i, j, a1, a2;
            Console.WriteLine("Enter the no. of rows");
            row = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= row; i++)
            {
                if (i % 2 == 0)
                {
                    a1 = 1;
                    a2 = 0;
                }
                else
                {
                    a1 = 0;
                    a2 = 1;
                }
                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0}\t", a1);
                else
                        Console.Write("{0}\t", a2);
                Console.WriteLine("\n");
            }
        }
    }
}
