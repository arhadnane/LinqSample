using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinq
{
    internal class upperCaseString
    {
        public static void Sample_Upper_Str()
        {
            string str = "test,yes,first,word,green,code";
            string[] strUpper = str.Split(',')
                           .Select(y => y.Substring(0, 1).ToUpper() + y.Substring(1))
                           .ToArray();

            Console.WriteLine(String.Join(",", strUpper)) ;
        }

    }
}
