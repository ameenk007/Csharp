using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_concepts
{
    public class VotingEligibility1 : Exception
    {
        public VotingEligibility1(string? message) : base(message)
        {

        }
    }
    public class VotingEligibility2 : Exception
    {
        public VotingEligibility2(string? message) : base(message)
        {

        }
    }
    public class VotingEligibility3 : Exception
    {
        public VotingEligibility3(string? message) : base(message)
        {

        }
    }
    public class multiplecatch
    {
        public static void Main()
        {
            int voter_age;
            try
            {
                Console.WriteLine("Enter your Age:");
                voter_age = Convert.ToInt32(Console.ReadLine());
                if (voter_age >= 21)
                {
                    throw (new VotingEligibility1("You are eligible for national-level voting"));
                }
                else if(voter_age>=18)
                {
                    throw (new VotingEligibility2("You are eligible for only state-level voting"));
                }
                else if(voter_age>=16)
                {
                    throw (new VotingEligibility2("You are eligible only for district-level voting"));
                }
                else
                {
                    Console.WriteLine("You are not eligible for voting");
                }
            }
            catch (VotingEligibility1 exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (VotingEligibility2 exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (VotingEligibility3 exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
