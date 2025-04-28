using PullYourLuck.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class GameBoardTests
    {
        [Fact]
        public void TestSetupGameBoard()
        {
            GameBoard board = new GameBoard();
            Assert.NotNull(board.deck);
            Assert.NotNull(board.hand);
        }

        [Fact]
        public void TestMoveCards()
        {
            GameBoard board = new GameBoard();
            Card card1 = new Card(1, "circle");
            board.hand.AddCard(card1);

            board.hand.SelectCardInHand(card1);
            board.PlaySelectedCard();

            int handCount = board.hand.GetHandCount();

            Assert.Equal(0, handCount);
            Assert.NotEmpty(board.playedCards);

        }

        [Fact]
        public void TestShufflePlayedCardsIntoDeck() {
            GameBoard board = new GameBoard();
            Card card1 = new Card(1, "circle");
            Card card2 = new Card(2, "circle");
            Card card3 = new Card(3, "circle");
            board.AddPlayedCard(card1);
            board.AddPlayedCard(card2);
            board.AddPlayedCard(card3);

            board.ShufflePlayedCardsIntoDeck();
            int DeckCount = board.deck.GetDeckCount();

            Assert.Empty(board.playedCards);
            Assert.Equal(3, DeckCount);
        }
    }
}
