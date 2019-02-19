using Framework.Templates.PageObject;
using NUnit.Framework;

namespace Pages
{
    public class BookRoomPageValidator : PageValidator<BookRoomPage>
    {
        public void AsserBookingWasSuccess()
        {
            var actualMessage = Page.MessageText.Text;
            var expectedMessage = "Будем благодарны за отзыв после прохождения квест-комнаты. Ваше мнение очень важно для будущих игроков.";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), 
                $"Booking wasn't success. We should receive {expectedMessage} message, but there is {actualMessage}");
        }
    }
}