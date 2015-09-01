using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Framework.Pages
{
    public class SportsHomePage : Page
    {

        [FindsBy(How = How.ClassName, Using = "nav-top")]
        public IWebElement PageBanner { get; set; }

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement SportsHomeLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Football")]
        public IWebElement FootballLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Formula 1")]
        public IWebElement FormulaOneLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cricket")]
        public IWebElement CricketLink { get; set; }

    }
}
