using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_PartitioningOperator
{
    class SkipWhile
    {
        static void Main()
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
            //IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);

            //Using LINQ to SQL Syntax
            IEnumerable<string> result = (from country in countries
                                          select country).SkipWhile(s => s.Length > 2);

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
