using System;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Framework.Common;
using Selenium.Framework.PageElements;
using Selenium.Framework.Setup;


namespace Selenium.Framework.Pages
{
    public abstract class Page : PageObject
    {
        public static string Url { get; set; }

        protected Page()
        {
            if (EnvironmentReader.get(GetType().Name) != null)
            {
                Url = EnvironmentReader.get(GetType().Name).Url;
                PageTitle = EnvironmentReader.get(GetType().Name).PageTitle;
            }
        }

        public Navigation Navigation
        {
            get
            {
                var page = new Navigation();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public PageHeader PageHeader
        {
            get
            {
                var page = new PageHeader();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        /// <summary>
        /// Navigates to the page URL.
        /// </summary>
        public void Goto()
        {
            try
            {
                Browser.Goto(Url);
                WaitForLoad();
            }
            catch (Exception e)
            {
                throw new Exception(GetType().Name + " could not be loaded. Check page url is correct in app.config." +
                                    " " + e.Message);
            }
        }

        /// <summary>
        /// Navigates tback to the previous page.
        /// </summary>
        public void GoBack()
        {
            try
            {
                Browser.GoBack();
            }
            catch (Exception e)
            {
                throw new Exception(GetType().Name + " could not be loaded. Check page url is correct in app.config." +
                                    " " + e.Message);
            }
        }
    }
}
