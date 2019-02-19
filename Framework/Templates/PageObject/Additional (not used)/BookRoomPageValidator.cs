using NUnit.Framework;

namespace Framework.Templates.PageObject
{
    //Verification Strategy: this is an example - underscope if you want to use
    public class BookRoomPageValidator // : PageValidator<BookRoomPage>
    {
        public void AsserBookingWasSuccess()
        {
           // var actualMessage = Page.MessageText.Text;
            var expectedMessage = "Будем благодарны за отзыв после прохождения квест-комнаты. Ваше мнение очень важно для будущих игроков.";
           // Assert.That(actualMessage, Is.EqualTo(expectedMessage), 
           //    $"Booking wasn't success. We should receive {expectedMessage} message, but there is {actualMessage}");
        }
    }
}