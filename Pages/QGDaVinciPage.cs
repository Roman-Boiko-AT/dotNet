using Framework.Core;
using Framework.Templates.PageObject;
using OpenQA.Selenium;

namespace Pages
{
    public class QGDaVinciPage : Page
    {
        public IWebElement CellWithBookDateAndTime(string date, string time)
        {
            return Driver.Browser.FindElement(By.XPath($".//a[contains(.,'{time}') and contains(@data-full-date,'{date}')]"));
        }
    }
}