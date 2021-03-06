﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace ScreenScraper
{
    public class ABScraper : IScraper
    {
        public string FindCompanyByOrgNo(string o)
        {
            var getHtmlWeb = new HtmlWeb();
            var pageResult = getHtmlWeb.Load(String.Format("http://www.allabolag.se/" + o));
            var orgName = pageResult.DocumentNode.SelectSingleNode("//span[@id='printTitle']").InnerText;
            return orgName;
        }
    }
}