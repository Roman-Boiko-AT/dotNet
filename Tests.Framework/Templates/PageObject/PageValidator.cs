namespace Tests.Framework.Templates.PageObject
{
    public abstract class PageValidator<P> where P : Page, new()
    {
        public readonly P page = new P();
    }
}