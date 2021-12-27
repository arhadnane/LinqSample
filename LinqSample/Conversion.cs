using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal class Conversion
    {
        internal static void Sample_AsEnumerable_Lambda()
        {
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
        }

        // Note: The source we're casting from must contain only elements of the same type.
        internal static void Sample_Cast_Lambda()
        {
            List<IComparable> number = new List<IComparable> { 10, 20, 30 };

            IEnumerable<int> result = number.Cast<int>();
            Console.WriteLine("List casted to a  integer array:");
            foreach (int n in result)
                Console.WriteLine(n);

            var sum = result.Sum();
            Console.WriteLine($"The sum of list is:{sum}");
        }

        internal static void Sample_OfType_Lambda()
        {
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = objects.OfType<string>();

            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
        }

        internal static void Sample_ToArray_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        internal static void Sample_ToDictionary_Lambda_Simple()
        {
            English2German[] english2German =
            {
                new English2German { EnglishSalute = "Good morning", GermanSalute = "Guten Morgen" },
                new English2German { EnglishSalute = "Good day", GermanSalute = "Guten Tag" },
                new English2German { EnglishSalute = "Good evening", GermanSalute = "Guten Abend" },
            };

            var result = english2German.ToDictionary(k => k.EnglishSalute, v => v.GermanSalute);

            Console.WriteLine("Values inserted into dictionary:");
            foreach (KeyValuePair<string, string> dic in result)
                Console.WriteLine(String.Format("English salute {0} is {1} in German", dic.Key, dic.Value));
        }

        internal  static void Sample_ToDictionary_Lambda_Conditional()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }

        internal static void Sample_ToList_Lambda()
        {
            string[] names = { "Brenda", "Carl", "Finn" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));
        }


        internal static void Sample_ToLookup_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }

    }

    class English2German
    {
        public string EnglishSalute { get; set; }
        public string GermanSalute { get; set; }
    }
}
