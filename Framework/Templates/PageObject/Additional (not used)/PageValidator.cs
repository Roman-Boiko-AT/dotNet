namespace Framework.Templates.PageObject
{
    public abstract class PageValidator<P> where P : Page, new()
    {
        private P _page;

        public P Page
        {
            set
            {
                if (_page == null)
                {
                    _page = value;
                }
            }
            protected get => _page; 
        }
    }
}