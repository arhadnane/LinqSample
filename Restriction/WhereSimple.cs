﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restriction
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class WhereSimple
    {
        internal static void Sample_Where_Lambda_Numbers()
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };

            var result = numbers.Where(n => n >= 15 && n <= 25);

            Console.WriteLine("Numbers being >= 15 and <= 25:");
            foreach (var number in result)
                Console.WriteLine(number);
        }


        internal static void Sample_Where_Lambda_Objects()
        {
            Person[] persons = {
                                    new Person { Name = "Mike", Age = 25 },
                                    new Person { Name = "Joe", Age = 43 },
                                    new Person { Name = "Nadia", Age = 31 }
                                };

            var result = persons.Where(p => p.Age >= 30);

            Console.WriteLine("Finding persons who are 30 years old or older:");
            foreach (Person person in result)
                Console.WriteLine(String.Format("{0}: {1} years old", person.Name, person.Age));
        }

        internal static void Sample_Where_Lambda_Indexed()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Where((n, i) => n % 3 == 0 && i >= 5);

            Console.WriteLine("Numbers divisible by 3 and indexed >= 5:");
            foreach (var number in result)
                Console.WriteLine(number);
        }

    }
}
