using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    public static class LongCount
    {
        // Use LongCount() when you expect the result to be greater than Int32.MaxValue()
        public static void Sample_LongCount_Lambda()
        {
            // Create array which is 5 elements larger than Int32.MaxValue
            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

            Int64 result = largeArr.LongCount();

            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);
        }
    }
}
