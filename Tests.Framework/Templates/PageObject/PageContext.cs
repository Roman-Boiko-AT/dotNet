namespace Tests.Framework.Templates.PageObject
{
    public abstract class PageContext<P, V> : PageContext<P>
        where P : Page, new()
        where V : PageValidator<P>, new()
    {
        protected readonly V pageValidator;

        public PageContext(string url) : base(url)
        {   
            pageValidator = new V();
        }

        public V Validate()
        {
            return pageValidator;
        }
    }
}