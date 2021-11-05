using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the target number");
            string target = Console.ReadLine();
            int t = Int32.Parse(target);
            
            Console.WriteLine("Please enter the list of numbers");
            string[] arrItems = Console.ReadLine().Split(' ');
            List<double> lstItems = new List<double>(Array.ConvertAll(arrItems, arrTemp => Convert.ToDouble(arrTemp)));

            var answer = FindTwoSum(t, lstItems);
            var check = Tuple.Create(0, 0);

            if (t>0 && answer.Item1 == 0 && answer.Item2 == 0)
            {
                Console.WriteLine("There is no correct answer");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("One of the answers is:{0}", answer);
                Console.ReadLine();
            }

        }

        private static Tuple<int, int> FindTwoSum(int input, List<double> numInput ) { 
            numInput.Sort();
            double target = Convert.ToDouble(input);
            double numMax = numInput.LastOrDefault();
            double numMin = numInput.First();
            int answer1;
            int answer2;

            if ((numMax + numMin) > target)
            {
                return Tuple.Create(0, 0);
            }
            if ((numMax + numInput[numInput.Count - 2]) < target)
            {
                return Tuple.Create(0, 0);
            }

            for (int i = 0; i < numInput.Count; i++) { 
                if (numInput[i]+numMax < target)
                {
                    continue;
                }
                for (int j = numInput.Count-1; j > i; j--) {
                    if (numInput[j] + numInput[i] > target)
                    {
                        continue;
                    }
                    if (numInput[j] + numInput[i] < target)
                    {
                        return Tuple.Create(0, 0);
                    }
                    if (numInput[i] + numInput[j] == target) {
                        answer1 = Convert.ToInt32((double)numInput[i]);
                        answer2 = Convert.ToInt32((double)numInput[j]);
                        return Tuple.Create(answer1, answer2);
                    }
                }
            }
            return Tuple.Create(0, 0);
        }
    }
}
