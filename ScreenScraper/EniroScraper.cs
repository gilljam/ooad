using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace ScreenScraper
{
    public class EniroScraper : IScraper
    {
        public string FindCompanyByOrgNo(string o)
        {
            var getHtmlWeb = new HtmlWeb();
            var pageResult = getHtmlWeb.Load(String.Format("http://gulasidorna.eniro.se/hitta:" + o));
            var orgName = pageResult.DocumentNode.SelectSingleNode("//*[@id='hit-list']/li/article/header/div[2]/h2/span/a").InnerText;
            return orgName;
        }
    }
}