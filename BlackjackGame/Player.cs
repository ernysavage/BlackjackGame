using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

    public class Player
    {
        public string Nickname { get; private set; }
        public List<Card> Hand { get; private set; }
        public int PlayerScore { get; private set; }
        public int Dibs { get; set; }
        public int Bet { get; private set; }

        public Player(string nickname, int dibs)
        {
            Nickname = nickname;
            Dibs = dibs;
            Hand = new List<Card>();
        }

        public void makeBet(int dibs)
        {
            if (dibs > Dibs)
            {
                MessageBox.Show("Недостаточно фишек для ставки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bet = dibs;
                Dibs -= dibs;
            }
        }

        public void takeCard(Card card)
        {
            Hand.Add(card);
        }

        public void doubleUp(Card card)
        {
            if (Bet > Dibs)
            {
                MessageBox.Show("Недостаточно фишек для ставки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dibs -= Bet;
                Bet *= 2;
                takeCard(card);
            }
        }

        public void clean()
        {
            Hand.Clear();
            PlayerScore = 0;
            Bet = 0;
        }

        public List<Card> getHand()
        {
            return Hand;
        }

        public string getName()
        {
            return Nickname;
        }

        public int getDibs()
        {
            return Dibs;
        }

        public int getPlayerScore()
        {
            return new Game().CalculateScore(Hand);
        }

        public void pass()
        {
            Dibs += Bet / 2;
            Bet = 0;
            clean();
        }
    }

}
