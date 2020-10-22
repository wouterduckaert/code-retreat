using System.Text;
using NUnit.Framework;
​
namespace Tests
{
    [TestFixture]
    class TicTacToeTests
    {
        [Test]
        public void GameStarted_ShowsEmptyBoard()
        {
            var result = Board.EmptyBoard;
​
            Assert.That(result, Is.EqualTo(Board.EmptyBoard));
        }
​
        [Test]
        public void MakeAMove_ShowMoveOnTheBoard()
        {
            int position = 1;
​
            var builder = new StringBuilder(Board.EmptyBoard);
            builder.Remove(position - 1, 1);
            builder.Insert(position - 1, 'X');
            var result = builder.ToString();
​
            Assert.That(result, Is.EqualTo("X  |   |   "));
        }
    }
​
    public class Board
    {
        public const string EmptyBoard = "   |   |   ";
    }
}