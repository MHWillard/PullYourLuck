namespace PullYourLuck.GameObjects
{
    public class Hand
    {
        List<Card> hand;
        Card selectedCard;
        List<Card> selectedCards;
        public Hand() {
            this.hand = new List<Card>();
        }

        public Hand(List<Card> cards)
        {
            this.hand = new List<Card>();
            this.hand = cards;
        }

        public void DrawCard(Card card)
        {
            this.AddCard(card);
        }
        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public void SelectCardInHand(Card card)
        {
            this.hand.Remove(card);
            this.selectedCard = card;
        }

        public Card PlaySelectedCard()
        {
            return this.selectedCard;
        }

        public int GetHandCount()
        {
            return hand.Count;
            //return 1;
        }
    }
}
