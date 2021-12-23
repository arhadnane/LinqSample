using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal static class Ordering
    {
        internal static void Sample_OrderBy_Lambda_Numbers()
        {
            int[] numbers = { 7, 9, 5 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        internal static void Sample_OrderBy_Lambda_Dates()
        {
            var dates = new DateTime[] {
                                        new DateTime(2015, 2, 15),
                                        new DateTime(2015, 3, 25),
                                        new DateTime(2015, 1, 5)
                                    };

            var result = dates.OrderBy(d => d);

            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }


        private class Car
        {
            public string? Name { get; set; }
            public int HorsePower { get; set; }
        }

        internal static void Sample_OrderBy_Lambda_Objects()
        {
            Car[] cars =
                {
            new Car { Name = "Super Car", HorsePower = 215 },
            new Car { Name = "Economy Car", HorsePower = 75 },
            new Car { Name = "Family Car", HorsePower = 145 },
        };

            var result = cars.OrderBy(c => c.HorsePower);

            Console.WriteLine("Ordered list of cars by horsepower:");
            foreach (Car car in result)
                Console.WriteLine(String.Format("{0}: {1} horses", car.Name, car.HorsePower));
        }
    }
}
