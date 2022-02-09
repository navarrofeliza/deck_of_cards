namespace DeckOfCards
{
    class Card
    {
        public string cardValue;
        public string cardSuit;
        public int val;
        public Card(string suit, string value, int number)
        {
            cardValue = value;
            cardSuit = suit;
            val = number;
        }
        public override string ToString()
        {
            return cardValue + "of" + cardSuit;
        }
    }
}