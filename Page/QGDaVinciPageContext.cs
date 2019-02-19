using Pages;
using Tests.Framework.Templates.PageObject;

namespace Page
{
    public class QGDaVinciPageContext : PageContext<QGDaVinciPage>
    {
        public QGDaVinciPageContext() : base("https://questgames.com.ua/quest/taini_da_vinchi_30"){}

        public void ChooseDate(string date, string time)
        {
            page.CellWithBookDateAndTime(date, time).Click();
        }

        public void BookRoom(string name, string email, string phoneNumber)
        {
            page.NameTextField.SendKeys(name);
            page.EmailTextField.SendKeys(email);
            page.PhoneNumberTextField.SendKeys(phoneNumber);
            page.BookQuestButton.Click();
        }
    }
}