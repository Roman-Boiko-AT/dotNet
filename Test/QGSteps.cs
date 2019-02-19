using Pages;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    class QGSteps
    {
        [Given(@"I book a room '(.*)' at '(.*)'")]
        public void BookRoomAt(string date, string time)
        {
            #region Data

            string name = "test";
            string email = "seeker94@i.ua";
            string phone = "0677777777";

            #endregion

            new QGDaVinciPageContext().ChooseDate(date, time);
            var bookPage = new BookRoomPageContext();
            bookPage.BookRoom(name, email, phone);
            bookPage.AsserBookingWasSuccess();
        }
    }
}