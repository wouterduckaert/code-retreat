using System.Text;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    class TicTacToeTests
    {
        [Test]
        public void GameStarted_ShowsEmptyBoard()
        {
            var result = Board.EmptyBoard;
            Assert.That(result, Is.EqualTo(Board.EmptyBoard));
        }
        [TestCase(1, "X  |   |   ")]
        [TestCase(3, "  X|   |   ")]
        public void MakeAMove_ShowMoveOnTheBoard(int position, string expectedResult)
        {
            var result = Board.MakeMove(position);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
    public class Board
    {
        public const string EmptyBoard = "   |   |   ";
        public static string MakeMove(int position)
        {
            var builder = new StringBuilder(EmptyBoard);
            builder.Remove(position - 1, 1);
            builder.Insert(position - 1, 'X');
            var result = builder.ToString();
            return result;
        }
    }
}