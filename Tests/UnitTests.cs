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
            int SuccessChance = 99;
            int BustChance = 1;

            bool Success = RollChances(SuccessChance, BustChance);
            Assert.True(Success);
        }

        [Fact]
        public void TestModifyChances()
        {
            int SuccessChance = 99;
            int BustChance = 1;

            ModifyChances(SuccessChance, BustChance, 5);
            Assert.Equal(94, SuccessChance);
            Assert.Equal(6, BustChance);
        }
    }
}