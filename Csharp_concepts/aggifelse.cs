using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregateandaverage
{
    internal class aggifelse
    {
        public static void Main()
        {
            int sub1, sub2, sub3, total, avg, count;
            count = 3;
            Console.WriteLine("Enter the marks scored in first subject: ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks scored in Second subject: ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks scored in Third subject: ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
                total = sub1 + sub2 + sub3;
            avg = total / count;
            Console.WriteLine("The total of {0} subjects: {1}\nThe average of {0} subjects: {2}\n",count,total,avg);
            if (sub1 > 100)
            {
                Console.WriteLine("Invalid marks entered");
            }
            else if (sub2 > 100)
            {
                Console.WriteLine("Invalid marks entered");
            }
            else if (sub3 > 100)
            {
                Console.WriteLine("Invalid marks entered");
            }
            else
            {
                if (total > 280)
                {
                    Console.WriteLine("You are ranked with Distinction");
                }
                else if (total > 250)
                {
                    Console.WriteLine("You are ranked with Excellence");
                }
                else if (total > 210)
                {
                    Console.WriteLine("You are ranked with First class");
                }
                else if (total > 170)
                {
                    Console.WriteLine("You are ranked with Second class");
                }
                else
                {
                    Console.WriteLine("You are failed");
                }
            }
        }
    }
}
