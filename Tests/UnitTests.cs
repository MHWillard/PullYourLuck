using PullYourLuck.Services;
using PullYourLuck.GameObjects;

namespace PullYourLuck.Tests
{
    public class UnitTests
    {
        [Fact]
        public void TestRollNumbers()
        {
            int Score = 0;
            Random rnd = new Random();
            int NewScore = rnd.Next(1, 7);
            Score = NewScore;
            Assert.NotEqual(0, Score);
        }

        [Fact]
        public void TestRollChanceToBust()
        {
            ChanceWorker worker = new ChanceWorker();

            int SuccessChance = 99;
            int BustChance = 1;

            bool Success = worker.RollChances(SuccessChance, BustChance);
            Assert.True(Success);
        }

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

            deck.DrawCard();

            int deckCount = deck.GetDeckCount();
            int handCount = hand.GetHandCount();
            Assert.Equal(2, deckCount);
            Assert.Equal(1, handCount);

        }

        //deck of cards: from 0-5, can keep drawing but if you hit 0, it's a bust
        //otherwise you can cash it into your score and for each round you need at least X score; more points = more coins
        //use coins you earn to buy more cards, bonuses, perks, etc.
        //card have ratings and keywords for special abilities
    }
}