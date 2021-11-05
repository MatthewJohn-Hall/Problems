using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] sequence = new[] { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            int maxSequence = 0;
            int count = 0;

            for (int i = 1; i < sequence.Length; i++)
            {

                if (sequence[i] > 0)
                {
                    count = 0;
                }

                if (sequence[i] == 0)
                {
                    count++;
                    if (count > maxSequence)
                    {
                        maxSequence = count;
                    }
                }
           }

            Console.WriteLine("The longest sequence of days with no sales is {0}", maxSequence);
            Console.ReadLine();
        }
    }
}
