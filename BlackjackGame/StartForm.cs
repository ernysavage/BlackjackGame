using System;
using System.Windows.Forms;

namespace BlackjackGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTextBox.Text;
            if (int.TryParse(betTextBox.Text, out int dibsAmount) && dibsAmount > 0)
            {
                GameForm gameForm = new GameForm(playerName, dibsAmount, this);
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную ставку.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
