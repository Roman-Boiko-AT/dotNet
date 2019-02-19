using Framework.Core;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Templates.PageObject
{
    public abstract class PageContext<P> where P : Page, new()
    {
        protected readonly P page;
        protected readonly string url;
        protected readonly int elementTimeOut = 15;

        protected PageContext(string url)
        { 
            page = new P();
            this.url = url;
            Driver.Browser.Navigate().GoToUrl(url);
            PageFactory.InitElements(Driver.Browser, page);
            //RetryingElementLocator retry = new RetryingElementLocator(Driver.Browser, TimeSpan.FromSeconds(elementTimeOut));
            //IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();  --  some retry setup (need to think if we need that)
            //PageFactory.InitElements(retry.SearchContext, this); // decor);
        }
    }
}