using PullYourLuck.Controllers;
using PullYourLuck.Interfaces;

namespace PullYourLuck.GameObjects
{
    public class GameBoard
    {
        public Hand hand;
        public Deck deck;
        public List<Card> holdingZone;
        public List<Card> playedCards;
        public int currentScore;
        public ScoreController score;

        public GameBoard()
        {
            this.hand = new Hand();
            this.deck = new Deck();
            this.playedCards = new List<Card>();
            this.score = new ScoreController();
            this.currentScore = 0;
        }

        public void AddPlayedCard(Card card)
        {
            this.playedCards.Add(card);
        }

        public void PlaySelectedCard()
        {
            Card card = hand.PlaySelectedCard();
            this.playedCards.Add(card);
        }

        public void CalculateScore()
        {
            int CurrentScore = this.score.CalculateScore(this.playedCards);
            this.currentScore = CurrentScore;
        }

    }
}
