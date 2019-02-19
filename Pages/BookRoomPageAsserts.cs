using NUnit.Framework;

namespace Pages
{
    public static class BookRoomPageAsserts
    {
        public static void AsserBookingWasSuccess(this BookRoomPageContext pageContext)
        {
            var actualMessage = pageContext.MessageText();
            var expectedMessage = "Будем благодарны за отзыв после прохождения квест-комнаты. Ваше мнение очень важно для будущих игроков.";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage),
                $"Booking wasn't success. We should receive {expectedMessage} message, but there is {actualMessage}");
        }
    }
}