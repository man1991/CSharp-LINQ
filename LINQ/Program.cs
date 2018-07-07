using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLtoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement books = XElement.Parse(
            @"<books>
                <book>
                    <title>Pro LINQ: Language Integrated Query in C#2010</title>
                    <author>Joe Rattz</author>
                </book>
                <book>
                    <title>Pro .NET 4.0 Parallel Programming in C#</title>
                    <author>Adam Freeman</author>
                </book>
                <book>
                    <title>Pro VB 2010 and the .NET 4.0 Platform</title>
                    <author>Andrew Troelsen</author>
                </book>
            </books>");

            //XElement Xbooks = XElement.Parse(@"XMLFile.xml");
            var titles =
            from book in books.Elements("book")
            where (string)book.Element("author") == "Joe Rattz"
            select book.Element("title");
            foreach (var title in titles)
                Console.WriteLine(title.Value);
            Console.ReadLine();
        }
    }
}
