using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Framework.PageElements
{
    public class Navigation : PageHeader
    {
        [FindsBy(How = How.ClassName, Using = "blq-home")]
        public IWebElement BBCHome { get; set; }

        [FindsBy(How = How.ClassName, Using = "orb-nav-news")]
        public IWebElement News { get; set; }

        [FindsBy(How = How.ClassName, Using = "orb-nav-sport")]
        public IWebElement Sport { get; set; }

        [FindsBy(How = How.LinkText, Using = "Football")]
        public IWebElement Football { get; set; }

        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement Weather { get; set; }

        public void GoTo(string siteLocation)
        {
            string expectedPageTitle;

            switch (siteLocation)
            {
                case "BBCHome":
                    BBCHome.Click();
                    expectedPageTitle = "BBC - Home";
                    break;
                case "NewsHome":
                    News.Click();
                    expectedPageTitle = "Home - BBC News";
                    break;
                case "SportsHome":
                    Sport.Click();
                    expectedPageTitle = "BBC Sport - Sport";
                    break;
                case "FootballHome":
                    Football.Click();
                    expectedPageTitle = "BBC Sport - Football";
                    break;
                default:
                    expectedPageTitle = "Unknown location";
                    break;
            }

            var wait = Browser.Wait();

            try
            {
                wait.Until(p => p.Title == expectedPageTitle);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
