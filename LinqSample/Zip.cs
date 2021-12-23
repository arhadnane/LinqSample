using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal static class Zip
    {
        internal static void Sample_Zip_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 10, 11, 12 };

            var result = numbers1.Zip(numbers2, (a, b) => (a * b));

            Console.WriteLine("Using Zip to combine two arrays into one (1*10, 2*11, 3*12):");
            foreach (int number in result)
                Console.WriteLine(number);
        }
    }
}
