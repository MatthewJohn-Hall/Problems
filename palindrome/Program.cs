using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter input to check:");
            string input = Console.ReadLine();

            if (input.SequenceEqual(input.Reverse()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
