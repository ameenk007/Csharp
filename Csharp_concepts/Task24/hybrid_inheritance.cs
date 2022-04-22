using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    internal class hybrid_inheritance
    {
        public class grandpa
        {
            public void land()
        {
            Console.WriteLine("Grandpa own the land");
        }
        }
        public class father: grandpa
        {
            public void home()
            {
                Console.WriteLine("Father owns the home in grandpa's land");
            }
            public void vehicle()
            {
                Console.WriteLine("Father owns a car");
            }
        }
        public class son: father
        {
            public son()
            {
                Console.WriteLine("Level son\n");
            }
                public void mobile()
            {
                Console.WriteLine("Son owns a mobile thats inherited from father");
            }
        }
        public class daughter: father
        {
            public daughter()
            {
                Console.WriteLine("\n\nLevel daughter\n");
            }
            public void laptop()
            {
                Console.WriteLine("Daughter owns a laptop thats inherited from father");
            }
        }
        public static void Main()
        {
            son s=new son();
            s.land();
            s.home();
            s.vehicle();
            s.mobile();
            daughter d=new daughter();
            d.land();
            d.home();
            d.vehicle();
            d.laptop();
        }
    }
}
