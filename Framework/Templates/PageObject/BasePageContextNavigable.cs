using Framework.Core;

namespace Framework.Templates.PageObject
{
    public class PageContextNavigable<P> : PageContext<P>, INavigable where P : Page, new()
    {
        public PageContextNavigable(string url) : base(url) { }

        void INavigable.Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }   
}