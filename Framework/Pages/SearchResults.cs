using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Framework.Pages
{
    public class SearchResults : Page
    {
        [FindsBy(How = How.ClassName, Using = "search-box")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "search-q")]
        public IWebElement SearchBoxText { get; set; }

        [FindsBy(How = How.ClassName, Using = "search-results")]
        public IWebElement SearchFoundItems { get; set; }

        [FindsBy(How = How.Id, Using = "search-content")]
        public IWebElement SearchContent { get; set; }


        ///// <summary>
        ///// Checks that the page search input box contains the text entered at the time of the initial search.
        ///// </summary>
        ///// <returns>Returns true if the correct search text is found.</returns>
        public bool SearchTextContains(string searchText)
        {
            string value = this.SearchBoxText.GetAttribute("value");
            if (value.Contains(searchText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///// <summary>
        ///// Checks that the search results header or summary contain the search text.
        ///// </summary>
        ///// <returns>Returns true if the correct search text is found.</returns>
        public bool CheckFoundResultsForSearch()
        {
            int resultsCount = 0;
            if (int.TryParse(SearchFoundItems.GetAttribute("data-total-results"), out resultsCount))
            {
                return (resultsCount > 0);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Searches the page for the search results, nothing found element.
        /// </summary>
        /// <returns>Returns true if it find the element containing the unsuccessful match message.</returns>
        public bool UnsuccessfulSearch()
        {
            IWebElement message = SearchContent.FindElement(By.XPath("p"));
            if (message.Displayed)
            {
                string messageText = message.Text;
                return messageText.StartsWith("Sorry, there are no results for");
            }
            return false;
        }
    }
}
