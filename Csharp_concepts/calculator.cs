using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class calculator
    {
        public static void Main()
        {
            int oprnd1;
            int oprnd2;
            int result;
            Console.WriteLine("Enter the first operand");
            oprnd1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second operand");
            oprnd2= Convert.ToInt32(Console.ReadLine());
                char operators;
                Console.WriteLine("Enter the opration to be performed");
                operators = Convert.ToChar(Console.ReadLine());
            switch (operators)
            {
                case '+':
                    result =Convert.ToInt32(oprnd1 + oprnd2);
                    Console.WriteLine("Result= {0}", result);
                    break;
                case '-':
                    result = Convert.ToInt32(oprnd1 - oprnd2);
                    Console.WriteLine("Result= {0}", result);
                    break;
                case '*':
                    result = Convert.ToInt32(oprnd1 * oprnd2);
                    Console.WriteLine("Result= {0}", result);
                    break;
                case '/':
                    result = Convert.ToInt32(oprnd1 / oprnd2);
                    Console.WriteLine("Result= {0}", result);
                    break;
                case '%':
                    result = Convert.ToInt32(oprnd1 % oprnd2);
                    Console.WriteLine("Result= {0}", result);
                    break;
                default:
                    Console.WriteLine("No opration done");
                    break;
            }
            
        }
    }
}
