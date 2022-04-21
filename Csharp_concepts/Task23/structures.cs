using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class structures
    {
        struct coordinate
        {
            public int x;
            public int y;
            public coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static void Main()
        {
            coordinate point = new coordinate(5,10);
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
