using System;

namespace WebScrapingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryScraper scraper = new();

            var countries = scraper.GetCountries();

            foreach ( var country in countries )
            {
                Console.WriteLine( $"Nazwa: {country.Name}, Kraj: {country.Country}, HTML: {country.Html}");
            }
            Console.ReadKey();
        }
    }
}