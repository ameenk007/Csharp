using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
public class Swap_debug2  
   {  
     public static void Main()
    {
        int a=5, b=10;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b;
        b = a / b;
        a = a / b;
        Console.Write("After swap a= " + a + " b= " + b);
    }

}
}
