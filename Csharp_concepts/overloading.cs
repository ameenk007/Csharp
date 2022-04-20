using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class overloading
    {
        //static variable
       static int area1;
        /// <summary>
        /// area of square
        /// </summary>
        /// <param name="a"></param>
        public static void area(int a)
        {
            
            area1 = a * a;
            Console.WriteLine("The area of square:{0}", area1);
        }
        /// <summary>
        /// area of rectangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void area(int a, int b)
        {
            area1 = a * b;
                Console.WriteLine("The area of rectangle:{0}", area1);
        }
        /// <summary>
        /// area of circle
        /// </summary>
        /// <param name="r"></param>
        public static void area(float r)
        {
            //typecasting on area1
            area1 = (int)(3.14 *r * r) ;
            Console.WriteLine("The area of circle:{0}", area1);
        }
        public static void Main()
        {
            area(5);
            area(3, 4);
            area(3f);
        }
    }
}
