using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts.task22
{
    internal class pascaltriangle
    {
        public static void Main()
        {
            int row, i, j, blank, c = 1;
            Console.WriteLine("Enter the no. of rows");
                row=Convert.ToInt32(Console.ReadLine());
            for(i=0; i<row; i++)
            {
                for (blank = 1; blank <=row-i; blank++)
                    Console.Write("   ");
                for (j = 0; j <= i; j++)
                    {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write("{0}    ", c);
                }
                    Console.Write("\n\n");
            }
                
        }
    }
}
