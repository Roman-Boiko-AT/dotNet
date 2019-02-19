using NUnit.Framework;
using Pages;
using Tests.Framework.Templates.PageObject;

namespace Page
{
    public class BookRoomPageValidator : PageValidator<BookRoomPage>
    {
        public void AsserBookingWasSuccess()
        {
            var actualMessage = page.MessageText.Text;
            var expectedMessage = "Будем благодарны за отзыв после прохождения квест - комнаты.Ваше мнение очень важно для будущих игроков.";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), 
                $"Booking wasn't success. We should receive {expectedMessage} message, but there is {actualMessage}");
        }
    }
}
