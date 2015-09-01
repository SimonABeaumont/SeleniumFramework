using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Framework.Pages
{
    public class NewsHomePage : Page
    {

        [FindsBy(How = How.ClassName, Using = "nav-top")]
        public IWebElement PageBanner { get; set; }

    }
}
