using OpenQA.Selenium.Support.PageObjects;
using Selenium.Framework.PageElements;

namespace Selenium.Framework.Pages
{
    //This class allows access to system pages through the tests
    public static class Pages
    {

        public static HomePage HomePage
        {
            get
            {
                var page = new HomePage();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public static Navigation Navigation
        {
            get
            {
                var page = new Navigation();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public static NewsHomePage NewsHomePage
        {
            get
            {
                var page = new NewsHomePage();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public static SearchResults SearchResults
        {
            get
            {
                var page = new SearchResults();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public static SportsHomePage SportsHomePage
        {
            get
            {
                var page = new SportsHomePage();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }
    }
}
