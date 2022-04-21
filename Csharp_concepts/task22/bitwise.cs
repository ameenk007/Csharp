using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class bitwise
    {   
            public static void Main()
            {
            int a, b, res,res1,res2,res3,res4,res5,Lshift,Rshift;
            a = 10;
            b = 15;
            Lshift = 21;
            Rshift = 42;
            res = a | b;
            res1 = a & b;
            res2= a ^ b;
            res3= ~ b;
            Console.WriteLine("\n\n");
            Console.WriteLine("BitwiseOR operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwiseOR of {0} and {1} is: {2}",a,b,res);
            Console.WriteLine("\n\n");
            Console.WriteLine("BitwiseAND operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwiseOR of {0} and {1} is: {2}", a, b, res1);
            Console.WriteLine("\n\n");
            Console.WriteLine("BitwiseXOR operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwiseXOR of {0} and {1} is: {2}", a, b, res2);
            Console.WriteLine("\n\n");
            Console.WriteLine("BitwiseComplement operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwiseComplement of {0} is: {1}", b, res3);
            Console.WriteLine("\n\n");
            Console.WriteLine("Bitwise LeftShift operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwise LeftShift>> of {0} is: {1}", Lshift, Lshift<<2);
            Console.WriteLine("\n\n");
            Console.WriteLine("Bitwise RightShift operation");
            Console.WriteLine("____________________________");
            Console.WriteLine("\n\n");
            Console.WriteLine("bitwise RightShift of {0} is: {1}", Rshift, Rshift>>2);
        }
        
    }
}
