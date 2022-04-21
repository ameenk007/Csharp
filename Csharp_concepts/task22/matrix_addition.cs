using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class matrix_addition
    {
        public static void Main()
        {
            int i, j,n;
            int[,] arr1 = new int[50,50];
            int[,] arr2 = new int[50,50];
            int[,] arr3 = new int[50,50];
Console.WriteLine("Input the size of the matrix:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nInput the elements of first matrix\n\n");
            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.Write("Element -[{0},{1}]:", i, j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\nInput the elements of second matrix\n\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element -[{0},{1}]:", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\n\nThe first matrix is:\n");
            for(i = 0; i < n; i++)
            {
                Console.Write("\n");
                for(j = 0; j < n; j++)
                {
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }
            Console.Write("\n\nThe second matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("\n\nThe addition of two matrices is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }

            }
            Console.Write("\n\n");
        }
    }
}
