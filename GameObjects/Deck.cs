namespace PullYourLuck.GameObjects
{
    public class Deck
    {
        List<Card> cards;
        public Deck() { 
            this.cards = new List<Card>();
        }

        public Deck(List<Card> cardsToAdd)
        {
            this.cards = new List<Card>();
            this.cards = cardsToAdd;
        }

        public void DrawCard() { }
        public void AddCard(Card card) {
            cards.Add(card);
        }

        public int GetDeckCount() {
            return cards.Count;
            //return 2;
        }
    }
}
