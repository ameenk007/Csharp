using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{

    public class Arrays_debug1
    {
        public static void Main()
        {
            //creating variables
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("-----------------------------------------\n");


            /* Stored values into the array*/
            ///<summary>
            ///input of elements of array
            ///</summary>
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i <=2; i++)
            {
                for (j = 0; j <=2; j++)
                {
                    //entering the elements of array
                    Console.Write("element - [{0} {1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            ///<summary>
            ///display of the array sorted in the form of matrix 3x3
            ///</summary>
            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                //sorting the array into matrix format
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("[{0}]\t", arr1[i,j]);
            }
            Console.Write("\n\n");
        }
    }
}


