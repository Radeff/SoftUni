using System;

namespace _08.CardGame
{
    public class Card : IComparable<Card>
    {
        private CardSuit suit;
        private CardRank rank;

        public Card(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public CardSuit Suit { get; set; }

        public CardRank Rank { get; set; }

        private int GetCardPower()
        {
            return (int)this.Rank + (int) this.Suit;
        }

        public int CompareTo(Card other)
        {
            return this.GetCardPower() - other.GetCardPower();
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}