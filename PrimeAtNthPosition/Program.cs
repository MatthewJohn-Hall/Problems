using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeAtNthPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};
            Console.WriteLine("Please input a number");
            int pick = Int32.Parse(Console.ReadLine());
            Console.WriteLine(list[pick-1]);
            Console.ReadLine();
        }
    }
}
