using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String hello = "hello world";

            char[] charArray = hello.ToCharArray(); 
            Array.Reverse(charArray);

            Console.WriteLine(charArray);
            Console.ReadLine();


        }
    }
}
