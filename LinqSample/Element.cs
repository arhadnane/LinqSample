﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class Element
    {
        internal static void Sample_ElementAt_Lambda()
        {
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);
        }


        internal static void Sample_ElementAtOrDefault_Lambda()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }

        // Note: Operator First will throw an exception, if there is not at least one element in the sequence.
        internal static void Sample_First_Lambda_Simple()
        {
            string[] fruits = { "Banana", "Apple", "Orange" };

            var result = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }
        internal static void Sample_First_Lambda_Conditional()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };

            var result = countries.First(c => c.Length == 6);

            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);
        }


        // Note: While First() will throw an exception if array...
        //       ...is empty, FirstOrDefault gracefully returns null.
        internal static void Sample_FirstOrDefault_Lambda()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };

            var result = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }

        internal static void Sample_Last_Lambda()
        {
            int[] numbers = { 7, 3, 5 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);
        }

        // Note: While Last will throw an exception if array...
        //       ...is empty, LastOrDefault gracefully returns null.
        internal  static void Sample_LastOrDefault_Simple()
        {
            string[] words = { "one", "two", "three" };
            string[] empty = { };

            var result = words.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }

        // Note: While Last will throw an exception if array...
        //       ...is empty, LastOrDefault gracefully returns null.
        internal static void Sample_LastOrDefault_Conditional()
        {
            string[] words = { "one", "two", "three" };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }

        // Note: Single will throw an Exception, if there is not exactly one element in the array.
        internal static void Sample_Single_Lambda()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.Single();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            try
            {
                // This will throw an exception because array contains no elements
                var resultEmpty = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        // Note: SingleOrDefault retrieves null value if array is empty, and...
        //       ...throws an exception if array contains more than one element.
        public static void Sample_SingleOrDefault_Lambda()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
