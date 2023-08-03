using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingDemo
{
    public class CountryModel
    {

        public CountryModel(string name, string country, string html)
        {
            Name = name;
            Country = country;
            Html = html;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public string Html { get; set; }
    }
}
