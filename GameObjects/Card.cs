namespace PullYourLuck.GameObjects
{
    public class Card
    {
        private int _value { get; set; }
        private string _suit { get; set; }

        public Card(int value, string suit)
        {
            _value = value;
            _suit = suit;
        }
    }
}
