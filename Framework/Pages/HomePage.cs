using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Framework.Pages
{
    public class HomePage : Page
    {

        [FindsBy(How = How.ClassName, Using = "weather-container")]
        public IWebElement WeatherContainer { get; set; }
    }
}
