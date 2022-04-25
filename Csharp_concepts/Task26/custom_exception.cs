using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class VotingEligibility : Exception
    {
        public VotingEligibility(string? message) : base(message)
        {

        }
    }
    public class custom_exception
    {
        public static void Main()
        {
            int voter_age;
            try
            {
                Console.WriteLine("Enter your Age:");
                voter_age=Convert.ToInt32(Console.ReadLine());
                if(voter_age >= 18)
                {
                    throw (new VotingEligibility("You are eligible for voting"));
                }
                else
                {
                    Console.WriteLine("You are not eligible for voting");
                }
            }
            catch(VotingEligibility exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
