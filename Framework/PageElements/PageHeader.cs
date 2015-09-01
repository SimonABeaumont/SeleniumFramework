using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using Selenium.Framework.Pages;

namespace Selenium.Framework.PageElements
{
    public class PageHeader : Page
    {
        [FindsBy(How = How.Id, Using = "orb-header")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.Id, Using = "orb-search-button")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "orb-search-q")]
        public IWebElement SearchText { get; set; }

        public void EnterSearchText(string searchText)
        {
            SearchText.SendKeys(searchText);
        }

        public void ClickSearch()
        {
            SearchButton.Click();
        }

    }
}
