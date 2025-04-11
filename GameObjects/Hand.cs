namespace PullYourLuck.GameObjects
{
    public class Hand
    {
        List<Card> hand;
        public Hand() {
            this.hand = new List<Card>();
        }

        public Hand(List<Card> cards)
        {
            this.hand = new List<Card>();
            this.hand = cards;
        }

        public void DrawCard() { }
        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public int GetHandCount()
        {
            return hand.Count;
            //return 1;
        }
    }
}
