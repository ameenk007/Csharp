using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class sum_of_natural_no_with_array
    {
        public static void Main()
        {
            int size, i, sum=0;
            Console.WriteLine("Enter the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("Elements of array:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The array is");
            foreach (int number in arr)
            {
                Console.WriteLine("{0}\n",number);
            }
            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}
