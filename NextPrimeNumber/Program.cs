using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Please input a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool primeNumber = false;

            while (primeNumber == false)
            {
                primeNumber = true;

                answer = answer + 1;

                
                int squared = (int)Math.Sqrt(answer);

                for (int i = 2; i <= squared; i++) {

                    if (answer % i == 0){
                        primeNumber = false;
                        break;
                    }
                
                }

                
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
