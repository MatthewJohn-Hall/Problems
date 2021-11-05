using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] store = new[] { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };
            List<String> anagrams = new List<string>();
            String star = "star";
            char[] starArray = star.ToLower().ToCharArray();
            Array.Sort(starArray);

            for (int i = 1; i < store.Length; i++)
            {
                if (store[i].Length == star.Length) {
                
                    char [] storeArray = store[i].ToLower().ToCharArray();
                    Array.Sort(storeArray);

                    bool match = true;

                    for (int j = 0; j < storeArray.Length; j++) {
                        if (starArray[j].ToString() != storeArray[j].ToString()) {
                            match = false;
                        }
                    
                    }

                    if (match) {
                        anagrams.Add(store[i]);
                    }
                }
            }

            anagrams.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
