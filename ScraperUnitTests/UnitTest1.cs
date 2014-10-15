using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenScraper;

namespace ScraperUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestABScraper()
        {
            string testResult = ScraperFactory.Scrape("Allabolag.se", "556599-5239");
            string expectedResult = "Mattias Asplund Aktiebolag";

            Assert.AreEqual(testResult, expectedResult);
        }

        [TestMethod]
        public void TestEniroScraper()
        {
            string testResult = ScraperFactory.Scrape("Eniro.se", "556599-5239");
            string expectedResult = "Mattias Asplund AB\n";

            Assert.AreEqual(testResult, expectedResult);
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    ABScraper testScraper = new ABScraper();
        //    var testResult = testScraper.FindCompanyByOrgNo("556599-5239");
        //    string expectedResult = "Mattias Asplund Aktiebolag";

        //    Assert.AreEqual(testResult, expectedResult);
        //}
    }
}
