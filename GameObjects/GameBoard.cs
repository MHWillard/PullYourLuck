using PullYourLuck.Interfaces;

namespace PullYourLuck.GameObjects
{
    public class GameBoard
    {
        public Hand hand;
        public Deck deck;
        public HandInterface handInt;
        public List<Card> selectedCards;
        public List<Card> playedCards;

        public GameBoard()
        {
            this.hand = new Hand();
            this.deck = new Deck();
            this.handInt = new HandInterface();
            this.selectedCards = new List<Card>();
            this.playedCards = new List<Card>();
        }


        public void DrawCard()
        {
            Card card = this.deck.DrawCard();
            this.hand.AddCard(card);
        }

        public void AddCardToDeck(Card card)
        {
            this.deck.AddCard(card);
        }

        public void AddCardToHand(Card card)
        {
            this.hand.AddCard(card);
        }

        public void SelectCardInHand(Card card)
        {
            this.selectedCards.Add(card);
        }

        public void PlaySelectedCards()
        {
            this.playedCards.AddRange(this.selectedCards);
            this.selectedCards.Clear();
        }
    }
}
