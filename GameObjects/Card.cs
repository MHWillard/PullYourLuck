namespace PullYourLuck.GameObjects
{
    public class Card
    {
        public int _value { get; set; }
        public string _suit { get; set; }

        public Boolean _bust { get; set; }

        public List<string> _keywords { get; set; }

        public Card() { 
            _value = 0;
            _suit = "circle";
            _bust = false;
            _keywords = new List<string>();
        }

        public Card(int value, string suit)
        {
            _value = value;
            _suit = suit;
        }
    }
}
