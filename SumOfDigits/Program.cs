using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter input to check:");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            double DAnswer = 0;
            int answer;

            for (int i = 0; i < charArray.Length; i++)
            {
                DAnswer = DAnswer + char.GetNumericValue(charArray[i]);
            }
            answer = Convert.ToInt32((double)DAnswer);
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
