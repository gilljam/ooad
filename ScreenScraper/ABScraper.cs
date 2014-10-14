using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace ScreenScraper
{
    public class ABScraper
    {
        public string FindCompanyByOrgNo(string o)
        {
            string orgNo = o.Replace("-", "");
            var getHtmlWeb = new HtmlWeb();
            var pageResult = getHtmlWeb.Load(String.Format("http://www.allabolag.se/" + orgNo));
            var orgName = pageResult.DocumentNode.SelectSingleNode("//span[@id='printTitle']").InnerText;
            return orgName;
        }
    }
}