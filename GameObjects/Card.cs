namespace PullYourLuck.GameObjects
{
    public class Card
    {
        private int _value { get; set; }
        private string _suit { get; set; }

        private Boolean _bust { get; set; }

        private List<string> _keywords { get; set; }

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
