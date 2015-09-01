using NUnit.Framework;
using Selenium.Framework.Pages;
using TechTalk.SpecFlow;

namespace Selenium.Tests.Steps
{
    [Binding]
    class Search
    {

        [Given(@"I enter the search value '(.*)'")]
        [Then(@"I enter the search value '(.*)'")]
        public void GivenIEnterTheSearchValue(string searchText)
        {
            Pages.HomePage.PageHeader.EnterSearchText(searchText);
        }

        [Given(@"I click the search button")]
        public void GivenIClickTheSearchButton()
        {
            Pages.HomePage.PageHeader.ClickSearch();            
        }

        [Then(@"successful search results are shown for '(.*)'")]
        public void ThenSuccessfulSearchResultsAreShown(string searchText)
        {
            Assert.IsTrue(Pages.SearchResults.SearchTextContains(searchText));
            Assert.IsTrue(Pages.SearchResults.CheckFoundResultsForSearch());
        }

        [Then(@"unsucessful search message it shown")]
        public void ThenUnsucessfulSearchMessageItShown()
        {
            Assert.IsTrue(Pages.SearchResults.UnsuccessfulSearch());
        }

    }
}
