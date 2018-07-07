using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_PartitioningOperator
{
    class Skip
    {
        static void Main()
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
            //IEnumerable<string> result = countries.Skip(3);

            //Using LINQ to SQL Syntax
            IEnumerable<string> result = (from country in countries
                                          select country).Skip(3);

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
