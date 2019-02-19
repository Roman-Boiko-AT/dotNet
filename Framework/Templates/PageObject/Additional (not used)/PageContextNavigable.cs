using Framework.Core;

namespace Framework.Templates.PageObject
{
    public class PageContextNavigable<P, V> : PageContext<P, V>, INavigable
        where P : Page, new() 
        where V : PageValidator<P>, new()
    {
        public PageContextNavigable(string url) : base(url) { }

        void INavigable.Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }
}