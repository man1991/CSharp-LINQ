using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_PartitioningOperator
{
    class Take
    {
        static void Main()
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
            //IEnumerable<string> result = countries.Take(3);

            //Using LINQ to SQL Syntax
            IEnumerable<string> result = (from country in countries
                                         select country).Take(3);


            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
