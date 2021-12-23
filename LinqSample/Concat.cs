using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal class Concat
    {
        internal static void Sample_Concat_Lambda_Strings()
        {
            string[] vegetables = { "Tomato", "Cucumber", "Carrot" };
            string[] fruits = { "Apples", "Grapes", "Banana" };

            var result = vegetables.Concat(fruits);

            Console.WriteLine("Concatinating vegetables and fruits gives:");
            foreach (string piece in result)
                Console.WriteLine(piece);
        }
    }
}
