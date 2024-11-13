using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Card
    {
        public int Value { get; private set; }
        public string Image { get; private set; }
        private Suit Suit { get; set; }
        private Rank Rank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
            Image = $"{ToString()}_of_{Suit.ToString().ToLower()}.png";
            Value = (int)rank > 10 ? 10 : (int)rank;
            if (rank == Rank.Ace) Value = 11;
        }

        public Rank getRank()
        {
            return Rank;
        }

        public Suit getSuit()
        {
            return Suit;
        }

        public override string ToString()
        {
            switch (Rank)
            {
                case Rank.Two: return "2";
                case Rank.Three: return "3";
                case Rank.Four: return "4";
                case Rank.Five: return "5";
                case Rank.Six: return "6";
                case Rank.Seven: return "7";
                case Rank.Eight: return "8";
                case Rank.Nine: return "9";
                case Rank.Ten: return "10";
                case Rank.Jack: return "jack";
                case Rank.Queen: return "queen";
                case Rank.King: return "king";
                case Rank.Ace: return "ace";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(Card other)
        {
            return Value.CompareTo(other.Value);
        }
    }

}
