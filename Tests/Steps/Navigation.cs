using NUnit.Framework;
using Selenium.Framework.Pages;
using TechTalk.SpecFlow;

namespace Euroffice.Tests.Steps
{
    [Binding]
    public sealed class Navigation
    {
        [Given(@"That I have gone to the BBC website")]
        public void GivenThatIHaveGoneToTheWebsite()
        {
            Pages.HomePage.Goto();
        }

        [Given(@"I choose to go to '(.*)'")]
        [When(@"I choose to go to '(.*)'")]
        public void GivenIChooseToGoTo(string navigationChoice)
        {
            Pages.Navigation.GoTo(navigationChoice);
        }

        [Then(@"I am taken to the '(.*)' page")]
        public void ThenIAmTakenToThePage(string navigationChoice)
        {
            switch (navigationChoice)
            {
                case "NewsHome":
                    Assert.IsTrue(Pages.NewsHomePage.IsAt());
                    break;
                case "SportsHome":
                    Assert.IsTrue(Pages.SportsHomePage.IsAt());
                    break;
                case "BBCHome":
                    Assert.IsTrue(Pages.HomePage.IsAt());
                    break;
            }
            
        }

        [When(@"I go back from the '(.*)' page")]
        public void WhenIGoBackFromThePage(string currentPage)
        {
            switch (currentPage)
            {
                case "NewsHome":
                    Pages.NewsHomePage.GoBack();
                    break;
            }
            
        }

        [Then(@"I am on the '(.*)' page")]
        public void ThenIAmOnThePage(string destinationPage)
        {
            switch (destinationPage)
            {
                case "BBCHome":
                    Assert.IsTrue(Pages.HomePage.IsAt());
                    break;
            }
        }


    }
}
