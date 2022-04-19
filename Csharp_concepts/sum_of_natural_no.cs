using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class sum_of_natural_no
    {
        public static void Main()
        {
            int i = 1, sum = 0;
            while(i<50)
            {
                
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of the first {1} natural numbers= {0}", sum, i);
        }
    }
}
