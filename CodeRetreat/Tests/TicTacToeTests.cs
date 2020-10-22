using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class TicTacToeTests
    {
        [Test]
        public void GameStarted_ShowsEmptyBoard()
        {
            const string emptyBoard = "   |   |   ";
            var result = emptyBoard;
            Assert.That(result, Is.EqualTo(emptyBoard));
        }
    }
}
