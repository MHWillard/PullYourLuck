using PullYourLuck.Services;

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

        //deck of cards: from 0-5, can keep drawing but if you hit 0, it's a bust
        //otherwise you can cash it into your score and for each round you need at least X score; more points = more coins
        //use coins you earn to buy more cards, bonuses, perks, etc.
        //card have ratings and keywords for special abilities
    }
}