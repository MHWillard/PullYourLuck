using PullYourLuck.GameObjects;

namespace PullYourLuck.Interfaces
{
    public class HandInterface
    {
        public int GetHandCount(Hand hand) { 
            int HandCount = hand.GetHandCount();
            return HandCount;
        }

        public void DrawCard(Hand hand, Deck deck)
        {
            Card card = deck.DrawCard();
            hand.AddCard(card);
        }
    }
}
