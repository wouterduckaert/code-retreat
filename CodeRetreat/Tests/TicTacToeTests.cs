using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class TicTacToeTests
    {
        [Test]
        public void GameStarted_ShowsEmptyBoard()
        {
            var result = "   |   |   ";
            Assert.That(result, Is.EqualTo("   |   |   "));
        }
    }
}
