using System;
namespace Dlithe
{
    public class DlitheB2
    {
       public static void Main()
        {
            Console.WriteLine("Welcome to C# programming");
            int a = 12;
            Console.WriteLine("the value is:{0}",a);
            int b = 17;
            Console.WriteLine("the values of a & b are {0} & {1} respectively", a, b);
            float d = 3.145f;
            double e = 12.956734;
            Console.WriteLine("the float value is:{0}", d);
            Console.WriteLine("the double value is:{0}", e);
            string c = "Bootcamp";
            Console.WriteLine($"the value inside the string is:{c}");
            bool f= false;
            Console.WriteLine($"boolean value is:{f}");
            char g= 'A';
            Console.WriteLine($"the character is:{g}");
            Console.WriteLine($"the character is:" + g); //we can either use {g} or concatinate g (ie; +g) to show the value in result
        }
    }
}