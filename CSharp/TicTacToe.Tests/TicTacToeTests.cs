using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class TicTacToeTests
    {
        [Fact]
        public void Test_A()
        {
            int Winner = 0;
            TicTacToe ticClass = new TicTacToe();
            ticClass.SetBoard(3);
            Winner = ticClass.PlacePiece(1, 1, 1);
            Winner = ticClass.PlacePiece(2, 1, 2);
            Winner = ticClass.PlacePiece(1, 2, 1);
            Winner = ticClass.PlacePiece(2, 2, 2);
            Winner = ticClass.PlacePiece(1, 3, 1);
            Assert.Equal(1, Winner);
            ticClass.SetBoard(3);
            Winner = ticClass.PlacePiece(1, 1, 1);
            Winner = ticClass.PlacePiece(2, 1, 2);
            Winner = ticClass.PlacePiece(1, 2, 1);
            Winner = ticClass.PlacePiece(2, 2, 2);
            Winner = ticClass.PlacePiece(3, 3, 1);
            Winner = ticClass.PlacePiece(2, 3, 2);
            Assert.Equal(2, Winner);
        }

        [Fact]
        public void Test_B()
        {
            int Winner = 0;
            TicTacToe ticClass = new TicTacToe();
            ticClass.SetBoard(4);
            Winner = ticClass.PlacePiece(1, 1, 1);
            Winner = ticClass.PlacePiece(2, 1, 2);
            Winner = ticClass.PlacePiece(1, 2, 1);
            Winner = ticClass.PlacePiece(2, 2, 2);
            Winner = ticClass.PlacePiece(1, 3, 1);
            Winner = ticClass.PlacePiece(2, 3, 2);
            Winner = ticClass.PlacePiece(1, 4, 1);
            Assert.Equal(1, Winner);
        }
    }
}