using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class generics_calculator_task25
    {
        public class generics<T>
        {
            public T add(T a, T b)
            {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1+num2;
            }
            public T sub(T a, T b)
            {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1-num2;
            }
        public T mul(T a, T b)
            {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1*num2;
            }
        public T div(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 / num2;
            }
        }
        public static void Main()
        {
            int choose;
            Console.WriteLine("Enter the operation to be performed");
            choose = Convert.ToChar(Console.ReadLine());
            int a = 0, b = 0;
            generics<int> calc = new generics<int>();
            generics<double> calc2 = new generics<double>();
            switch(choose)
            {
                case '+':
                    Console.WriteLine("Enter the first operand");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second operand");
                    b = Convert.ToInt32(Console.ReadLine());
                    int sum= calc.add(a, b);
                    Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, sum);
                    break;
                case '-':
                    Console.WriteLine("Enter the first operand");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second operand");
                    b = Convert.ToInt32(Console.ReadLine());
                    int diff = calc.sub(a, b);
                    Console.WriteLine("difference of {0} and {1} is: {2}", a, b, diff);
                    break;
                case '*':
                    Console.WriteLine("Enter the first operand");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second operand");
                    b = Convert.ToInt32(Console.ReadLine());
                    int prod = calc.mul(a, b);
                    Console.WriteLine("product of {0} and {1} is: {2}", a, b, prod);
                    break;
                case '/':
                    Console.WriteLine("Enter the first operand");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second operand");
                    b = Convert.ToInt32(Console.ReadLine());
                    int div = calc.div(a, b);
                    Console.WriteLine("division of {0} and {1} is: {2}", a, b, div);
                    break;
                    default:
                    Console.WriteLine("Enter the operation");
                    break;
            }
        }
    }
}
