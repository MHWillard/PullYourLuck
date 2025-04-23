using PullYourLuck.Services;
using PullYourLuck.GameObjects;
using PullYourLuck.Interfaces;

namespace PullYourLuck.Tests
{
    public class UnitTests
    {
        [Fact]
        public void TestDrawCard()
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            Card card1 = new Card(1, "circle");
            Card card2 = new Card(2, "circle");
            Card card3 = new Card(3, "circle");

            deck.AddCard(card1);
            deck.AddCard(card2);
            deck.AddCard(card3);

            Card drawnCard = deck.DrawCard();
            hand.AddCard(drawnCard);

            int deckCount = deck.GetDeckCount();
            int handCount = hand.GetHandCount();
            Assert.Equal(2, deckCount);
            Assert.Equal(1, handCount);
        }

        [Fact]
        public void TestSetupGameBoard()
        {
            GameBoard board = new GameBoard();
            Assert.NotNull(board.deck);
            Assert.NotNull(board.hand);
        }

        [Fact]
        public void TestHandInterface() {
            GameBoard Game = new GameBoard();
            Card card1 = new Card(1, "circle");
            Game.AddCardToDeck(card1);
            Game.DrawCard();
            int HandCount = Game.hand.GetHandCount();
            Assert.Equal(1, HandCount);
        }

        [Fact]
        public void TestPlayCardFromHand() {
            GameBoard Game = new GameBoard();
            Card card1 = new Card(1, "circle");
            Game.AddCardToHand(card1);
            Game.SelectCardInHand(card1);
            Game.PlaySelectedCards();
        }

        //deck of cards: from 0-5, can keep drawing but if you hit 0, it's a bust
        //otherwise you can cash it into your score and for each round you need at least X score; more points = more coins
        //use coins you earn to buy more cards, bonuses, perks, etc.
        //card have ratings and keywords for special abilities
        //X hands per round
    }
}