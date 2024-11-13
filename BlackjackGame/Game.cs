using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Game
    {
        public int DealerScore { get; private set; }
        public List<Card> DealerHand { get; private set; }
        public List<Card> Deck { get; private set; }

        public Game()
        {
            DealerHand = new List<Card>();
            Deck = new List<Card>();
        }

        public void startGame()
        {
            generateDeck();
            shuffleDeck();
        }

        public bool dealerIsWinner()
        {
            return DealerScore <= 21;
        }

        public void dealTakeCard(Card card)
        {
            DealerHand.Add(card);
            CalculateScore(DealerHand);
        }

        public bool IsBlackJack(List<Card> hand)
        {
            if (hand.Count != 2) return false;

            Card card1 = hand[0];
            Card card2 = hand[1];

            bool isAceAndTenOrFace = (card1.getRank() == Rank.Ace && (card2.getRank() == Rank.Ten || card2.getRank() == Rank.Jack || card2.getRank() == Rank.Queen || card2.getRank() == Rank.King)) ||
                                     (card2.getRank() == Rank.Ace && (card1.getRank() == Rank.Ten || card1.getRank() == Rank.Jack || card1.getRank() == Rank.Queen || card1.getRank() == Rank.King));

            return isAceAndTenOrFace;
        }

        public int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                if (card.getRank() == Rank.Ace)
                {
                    score += 11;
                    aceCount++;
                }
                else if (card.getRank() == Rank.Jack || card.getRank() == Rank.Queen || card.getRank() == Rank.King)
                {
                    score += 10;
                }
                else
                {
                    score += card.Value;
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        public void DealInitialCards(Player player)
        {
            player.takeCard(pickCard());
            player.takeCard(pickCard());
            DealerHand.Add(pickCard());
            DealerHand.Add(pickCard());
        }

        public void dealClearCards()
        {
            DealerHand.Clear();
            DealerScore = 0;
        }

        public void dealEndTurn()
        {
            while (CalculateScore(DealerHand) <= 17)
            {
                DealerHand.Add(pickCard());
            }
        }

        public List<Card> getDeck()
        {
            return Deck;
        }

        public void shuffleDeck()
        {
            var random = new Random();
            Deck = Deck.OrderBy(x => random.Next()).ToList();
        }

        public Card pickCard()
        {
            var card = Deck[0];
            Deck.RemoveAt(0);
            return card;
        }

        public void generateDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Deck.Add(new Card(suit, rank));
                }
            }
        }

        public override string ToString()
        {
            return string.Join(", ", Deck);
        }

        public void resetGame()
        {
            Deck.Clear();
            DealerHand.Clear();
            DealerScore = 0;
            generateDeck();
            shuffleDeck();
        }
    }

}
