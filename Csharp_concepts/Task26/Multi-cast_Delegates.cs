using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public delegate void Multidel(int a, int b);
    public class Delegates
    {
        public void add(int a, int b)
        {
            Console.WriteLine("sum is {0}", a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("difference is {0}",a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("Product is {0}", a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine("division is {0}", a / b);
        }
        public static void Main()
        {
            Delegates del= new Delegates();
            Multidel calc= del.add;
            calc+=del.mul;
            calc+=del.div;
            calc += del.sub;
            calc(10, 10);
        }
    }
}
