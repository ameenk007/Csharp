using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class Interface
    {
        public interface IAreaofcircle
        {
            void display();
        }
        public interface IPerimeterofcircle
        {
            void display();
        }
        public class circle: IAreaofcircle, IPerimeterofcircle
        {
            void IAreaofcircle.display()
            {
                int r = 4;
                double area = 3.14 * r * r;
                Console.WriteLine("The area of circle is: {0}\n", area);
            }
            void IPerimeterofcircle.display()
            {
                int r = 5;
                double Perimeter = 2 * 3.14 * r;
                Console.WriteLine("The perimeter of circle is: {0}\n\n",Perimeter);
            }
            public static void Main()
            {
                IAreaofcircle areaofcircle = new circle();
                areaofcircle.display();
                IPerimeterofcircle Perimeterofcircle = new circle();
                Perimeterofcircle.display();
            }
        }
    }
}
