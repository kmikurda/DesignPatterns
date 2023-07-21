using System;
using System.Collections.Generic;

namespace Factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var factories = new List<DiscountFactory>
            {
                new CodeDiscountFactory(),
                new CountryDiscountFactory("PL"),
                new CountryDiscountFactory("asd")
            };

            foreach (var factory in factories)
            {
                Console.WriteLine($"Percentage: {factory.CreateDiscountService().DiscountPercentage}");
            }

            Console.ReadKey();
        }
    }
}