using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingDemo
{
    public class CountryScraper
    {
        private const string urlPathWebsite = "https://unece.org/trade/cefact/unlocode-code-list-country-and-territory";

        public IEnumerable<CountryModel> GetCountries()
        {
            var web = new HtmlWeb();
            var doc = web.Load(urlPathWebsite);

            var tableRows = doc.QuerySelectorAll("table tr").Skip(1).ToList();

            foreach ( var row in tableRows )
            {
                var tds = row.QuerySelectorAll("td");

                var code = tds[0].InnerText;
                var country = tds[1].InnerText;
                var htmlToDetailsAboutCountry = tds[1].QuerySelector("a").Attributes["href"].Value;

                yield return new CountryModel(code, country, htmlToDetailsAboutCountry);
            }        }
    }
}
