using System.Security.Cryptography.X509Certificates;
using Page;
using Tests.Framework.Core;
using Tests.Framework.Templates.PageObject;

namespace Pages
{
    public class BookRoomPageContext : PageContext<BookRoomPage, BookRoomPageValidator>
    {
        public BookRoomPageContext() : base(Driver.Browser.Url) {}

        public void BookRoom(string name, string email, string phoneNumber)
        {
            page.NameTextField.SendKeys(name);
            page.EmailTextField.SendKeys(email);
            page.PhoneNumberTextField.SendKeys(phoneNumber);
            page.BookQuestButton.Click();
        }
    }
}