using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGame
{
    public partial class GameForm : Form
    {
        private Game game;
        private Player player;
        private Form startForm;

        public GameForm(string playerName, int startDibs, Form startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
            InitializeGame(playerName, startDibs);
        }

        private void InitializeGame(string playerName, int startDibs)
        {
            game = new Game();
            player = new Player(playerName, startDibs);
            game.startGame();
            hitButton.Enabled = false;
            standButton.Enabled = false;
            doubleButton.Enabled = false;
            surrenderButton.Enabled = false;
            UpdateUI();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(betTextBox.Text, out int betAmount) && betAmount > 0)
            {
                if (betAmount <= player.getDibs())
                {
                    player.makeBet(betAmount);
                    game.DealInitialCards(player);
                    buttonStart.Enabled = false;
                    betTextBox.Enabled = false;
                    hitButton.Enabled = true;
                    standButton.Enabled = true;
                    doubleButton.Enabled = true;
                    surrenderButton.Enabled = true;
                    UpdateUI();

                    if (game.IsBlackJack(player.getHand()))
                    {
                        player.Dibs += Convert.ToInt16(player.Bet * 2.5);
                        MessageBox.Show("Блэкджек! Вы выиграли!");
                        EndRound();
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточно фишек для ставки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную ставку.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUI()
        {
            playerScoreLabel.Text = $"Счёт игрока {player.Nickname}: " + player.getPlayerScore().ToString();
            dealerScoreLabel.Text = "Счёт дилера: " + game.CalculateScore(game.DealerHand).ToString();
            playerDibsLabel.Text = "Баланс: " + player.getDibs().ToString();

            DisplayCards(player.getHand(), playerCardPanel);
            DisplayCards(game.DealerHand, dealerCardPanel);
        }

        private void DisplayCards(List<Card> hand, Panel panel)
        {
            panel.Controls.Clear();
            for (int i = 0; i < hand.Count; i++)
            {
                var card = hand[i];
                var pictureBox = new PictureBox
                {
                    Width = 71,
                    Height = 96,
                    Image = Image.FromFile($"./pngcards/{card.Image}"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(i * 75, 0)
                };
                panel.Controls.Add(pictureBox);
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            player.takeCard(game.pickCard());
            UpdateUI();

            if (player.getPlayerScore() == 21)
            {
                player.Dibs += Convert.ToInt32(betTextBox.Text) * 2;
                MessageBox.Show("Вы набрали 21. Победа.");
                EndRound();
            }
            else if (player.getPlayerScore() > 21)
            {
                MessageBox.Show("Перебор, вы проиграли");
                EndRound();
            }
            else
            {
                UpdateUI();
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            game.dealEndTurn();
            UpdateUI();

            int playerScore = player.getPlayerScore();
            int dealerScore = game.CalculateScore(game.DealerHand);

            if (playerScore > 21)
            {
                MessageBox.Show("Перебор, вы проиграли");
            }
            else if (dealerScore > 21)
            {
                player.Dibs += Convert.ToInt32(betTextBox.Text) * 2;
                UpdateUI();
                MessageBox.Show("Вы выиграли, у дилера перебор");
            }
            else if (playerScore > dealerScore)
            {
                player.Dibs += Convert.ToInt32(betTextBox.Text) * 2;
                UpdateUI();
                MessageBox.Show("Вы выиграли");
            }
            else if (playerScore < dealerScore)
            {
                MessageBox.Show("Вы проиграли");
            }
            else
            {
                player.Dibs += Convert.ToInt32(betTextBox.Text);
                UpdateUI();
                MessageBox.Show("Ничья");
            }
            EndRound();
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(betTextBox.Text, out int betAmount) && betAmount <= player.Dibs)
            {
                player.doubleUp(game.pickCard());
                betTextBox.Text = Convert.ToString(Convert.ToInt32(betTextBox.Text) * 2);
                UpdateUI();

                if (player.getPlayerScore() == 21)
                {
                    player.Dibs += Convert.ToInt32(betTextBox.Text) * 4;
                    UpdateUI();
                    MessageBox.Show("Вы набрали 21. Победа.");
                    EndRound();
                }
                else
                {
                    game.dealEndTurn();
                    UpdateUI();

                    int dealerScore = game.CalculateScore(game.DealerHand);

                    if (player.getPlayerScore() > 21)
                    {
                        MessageBox.Show("Перебор, вы проиграли");
                    }
                    else if (dealerScore > 21)
                    {
                        player.Dibs += Convert.ToInt32(betTextBox.Text) * 4;
                        UpdateUI();
                        MessageBox.Show("Вы победили, у дилера перебор");
                    }
                    else if (player.getPlayerScore() > dealerScore)
                    {
                        player.Dibs += Convert.ToInt32(betTextBox.Text) * 4;
                        UpdateUI();
                        MessageBox.Show("Вы выиграли");
                    }
                    else if (player.getPlayerScore() < dealerScore)
                    {
                        MessageBox.Show("Вы проиграли");
                    }
                    else
                    {
                        player.Dibs += Convert.ToInt32(betTextBox.Text);
                        UpdateUI();
                        MessageBox.Show("Ничья");
                    }
                    EndRound();
                }
            } else
            {
                MessageBox.Show("Недостаточно фишек для удвоения ставки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void surrenderButton_Click(object sender, EventArgs e)
        {
            player.pass();
            MessageBox.Show("Вы сдались и потеряли половину ставки");
            EndRound();
        }

        private void EndRound()
        {
            player.clean();
            game.resetGame();
            betTextBox.Enabled = true;
            buttonStart.Enabled = true;
            hitButton.Enabled = false;
            standButton.Enabled = false;
            doubleButton.Enabled = false;
            surrenderButton.Enabled = false;

            if (player.Dibs <= 0)
            {
                MessageBox.Show("У вас закончились фишки. Вы проиграли.");
                this.Close();
            }

            UpdateUI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            startForm.Show();
        }
    }

}
