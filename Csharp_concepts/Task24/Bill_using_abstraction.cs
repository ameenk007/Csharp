using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public abstract class Bill_using_abstraction
    {
        protected double unit_chg;
        public abstract void getunit_chg();
        public void calcu_bill(double bill)
        {
            Console.WriteLine("Your monthly electricity bill: {0}", unit_chg * bill);
        }
        public class DIV_C:Bill_using_abstraction
        {
            public override void getunit_chg()
            {
                unit_chg = 4;
            }
        }
        public class DIV_B : Bill_using_abstraction
        {
            public override void getunit_chg()
            {
                unit_chg = 6;
            }
        }
        public class DIV_A : Bill_using_abstraction
        {
            public override void getunit_chg()
            {
                unit_chg = 8;
            }
        }
        public class abstraction
        {
            public static void Main()
            {
                Console.WriteLine("Division A:");
                Bill_using_abstraction calc;
                calc = new DIV_C();
                calc.getunit_chg();
                calc.calcu_bill(114);
                Console.WriteLine("\n\nDivision B:");
                Bill_using_abstraction calc1;
                calc1 = new DIV_B();
                calc1.getunit_chg();
                calc1.calcu_bill(180);
                Console.WriteLine("\n\nDivision C:");
                Bill_using_abstraction calc2;
                calc2 = new DIV_A();
                calc2.getunit_chg();
                calc2.calcu_bill(300);
            }
        }
    }
}
