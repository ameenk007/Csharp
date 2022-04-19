using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee_details
{
    internal class Trainee_details
    {
        public static void Main()
        {
            int TID;
            string TNAME;
            string TDEPT;
            Console.WriteLine("Enter the Trainee ID: ");
            TID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainee Name: ");
            TNAME = Console.ReadLine();
            Console.WriteLine("Enter the Trainee Department: ");
            TDEPT = Console.ReadLine();
            Console.WriteLine($"Trainee ID: {TID}\nTrainee Name: {TNAME}\nTrainee Dept: {TDEPT}");
        }
  
    }
}
