using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberoflayer = 5, Space, numberOfStars;


            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (numberOfStars = 1; numberOfStars <= (2 * i) - 1; numberOfStars++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            for (int i = numberoflayer -1; i > 0; i--) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= numberoflayer - i; Space++) // Loop For Space  
                    Console.Write(" ");
                for (numberOfStars = 1; numberOfStars <= (2 * i) - 1; numberOfStars++)
                {
                    Console.Write("*");
                    
                }
                Console.Write("\n");


            }
            Console.ReadLine();
        }
    }
}
