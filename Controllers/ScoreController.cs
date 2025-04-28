using PullYourLuck.GameObjects;

namespace PullYourLuck.Controllers
{
    public class ScoreController
    {
        public int CalculateScore(List<Card> playedCards)
        {
            int totalScore = playedCards.Sum(p => p._value);
            return totalScore;

        }
    }
}
