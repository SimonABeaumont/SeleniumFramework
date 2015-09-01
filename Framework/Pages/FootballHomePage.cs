using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Framework.Pages;

namespace Euroffice.Framework.Pages
{
    class FootballHomePage: SportsHomePage
    {

        [FindsBy(How = How.ClassName, Using = "secondary-nav__items")]
        public IWebElement FootballPageMenu { get; set; }

    }
}
