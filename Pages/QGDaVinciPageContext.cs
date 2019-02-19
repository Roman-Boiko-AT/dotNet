using Framework.Core;
using Framework.Templates.PageObject;
using Framework.Wait;

namespace Pages
{
    public class QGDaVinciPageContext : PageContextNavigable<QGDaVinciPage>
    {
        public QGDaVinciPageContext() : base("https://questgames.com.ua/quest/taini_da_vinchi_30"){}

        public void ChooseDate(string date, string time)
        {
            page.CellWithBookDateAndTime(date, time).Click();
            var rto = Driver.Browser.Url;
            new SmartWait()
                .Message("You haven't been navigated to BookRoomPage. Maybe this date have been booked already.")
                .WaitUntil(() => Driver.Browser.Url != url);
        }
    }
}