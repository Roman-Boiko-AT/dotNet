using OpenQA.Selenium.Support.PageObjects;
using Tests.Framework.Core;

namespace Tests.Framework.Templates.PageObject
{
    public abstract class PageContext<P> where P : Page, new()
    {
        protected readonly P page;
        protected readonly string url;

        public PageContext(string url)
        {
            page = new P();
            this.url = url;
            Driver.Browser.Navigate().GoToUrl(url);
            PageFactory.InitElements(Driver.Browser, page);
        }
    }
}