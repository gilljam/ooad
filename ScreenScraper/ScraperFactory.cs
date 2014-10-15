using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScreenScraper
{
    public abstract class ScraperFactory
    {
        public static string Scrape(string websiteToScrape, string o)
        {
            string orgNo = o.Replace("-", "");
            IScraper scraper = SelectScraper(websiteToScrape);
            return scraper.FindCompanyByOrgNo(orgNo);
        }

        internal static IScraper SelectScraper(string websiteToScrape)
        {
            switch (websiteToScrape)
            {
                case "Eniro.se":
                    return new EniroScraper();
                default:
                    return new ABScraper();
            }
        }
    }
}