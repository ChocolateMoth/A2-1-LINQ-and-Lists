using System;
using System.Collections.Generic;
using System.Linq;

namespace egg
{
    class Program
    {


        static void Main(string[] args)
        {
            var parts = new[]
            {
                new Invoice(83,"Electric sander",  7, (decimal)7.98),
                new Invoice(24,"Power saw",  18, (decimal)99.99),
                new Invoice(7,"Sledge hammer",  11, (decimal)21.50),
                new Invoice(77,"Hammer",  76, (decimal)11.99),
                new Invoice(39,"Lawn mower",  3, (decimal)79.50),
                new Invoice(68,"Screwdriver",  106, (decimal)6.99),
                new Invoice(56,"Jig saw",  21, (decimal)11.00),
                new Invoice(3,"Wrench",  34, (decimal)7.50) };

            Console.WriteLine("Original");
            Console.WriteLine(parts);


            Console.WriteLine("Sort by Description");
            var DescriptionSort =
                from e in parts
                orderby e.PartDescription
                select e;
            //
            foreach (var dess in DescriptionSort)
            {
                Console.WriteLine(dess);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sort by Price");
            Console.WriteLine(" ");
            var PriceSort =
                from e in parts
                orderby e.Price
                select e;
            //
            foreach (var MONEE in PriceSort)
            {
                Console.WriteLine(MONEE);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Description and Quantity");
            Console.WriteLine(" ");
            var QuantitySort =
                from e in parts
                orderby e.Quantity
                select new {e.PartDescription, e.Quantity};
            foreach(var hOI in QuantitySort)
            {
                Console.WriteLine(hOI);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Price * Quantity");
            Console.WriteLine(" ");
            var InvoiceTotal =
                from e in parts
                let invoiceTotal = e.Price * e.Quantity
                orderby invoiceTotal
                select new { e.PartDescription, invoiceTotal };
            foreach (var voices in InvoiceTotal)
            {
                Console.WriteLine(voices);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Between 200 to 500");
            Console.WriteLine(" ");

            var bet200t500 =
                from e in InvoiceTotal
                where (e.invoiceTotal >= 200) && (e.invoiceTotal <= 500)
                select e;
            foreach(var lotzMonees in bet200t500)
            {
                Console.WriteLine(lotzMonees);
            }
        }
    }
}
//