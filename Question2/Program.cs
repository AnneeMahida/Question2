
using System;
using System.Linq;

namespace ProblemSet
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------");

            string String1 = "Supercalifragilisticexpialidocious";

            Console.WriteLine(String1 + " contains " + String1.Length + " letters");

            Console.WriteLine("------------------------------------------------------------------------");

           
            if (String1.Contains("ice"))
                Console.WriteLine(String1 + " contains ice as a substring ");


            Console.WriteLine("-------------------------------------------------------------------------");

            
            string String2 = "Honorificabilitudinitatibus";
            string String3 = "Bababadalgharaghtakamminarronnkonn";

           
            if (String1.Length > String2.Length)
            {
                if (String1.Length > String3.Length)
                    Console.WriteLine(String1 + " is the longest word");
                else if (String1.Length < String3.Length)
                    Console.WriteLine(String3 + " is the longest word");
                else
                    Console.WriteLine("Both " + String1 + " and " + String3 + " are the longest words");
            }
            else if (String1.Length < String2.Length)
            {
                if (String2.Length > String3.Length)
                    Console.WriteLine(String2 + " is the longest word");
                else if (String2.Length < String3.Length)
                    Console.WriteLine(String3 + " is the longest word");
                else
                    Console.WriteLine("Both " + String2 + " and " + String3 + " are the longest words");
            }
            else
            {
                if (String1.Length > String3.Length)
                    Console.WriteLine("Both " + String1 + " and " + String2 + " are the longest words");
                else if (String1.Length < String3.Length)
                    Console.WriteLine(String3 + " is the longest word");
                else
                    Console.WriteLine("All " + String1 + ", " + String2 + ", and" + String3 + " have the same length");
            }

            Console.WriteLine("--------------------------------------------------------------------------");

                       
            string[] stringArrayUnsorted = new string[]
                {
                    "Berlioz",
                    "Borodin",
                    "Brian",
                    "Bartok",
                    "Bellini",
                    "Buxtehude",
                    "Bernstein"
                };

            int length = stringArrayUnsorted.Length;

        
            var sortedArray = from a in stringArrayUnsorted
                              orderby a
                              select a;

            Console.WriteLine(sortedArray.First());
            Console.WriteLine(sortedArray.Last());

            Console.WriteLine("----------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}