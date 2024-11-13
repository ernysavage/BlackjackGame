namespace BlackjackGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.playerDibsLabel = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.surrenderButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dealerCardPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.playerCardPanel = new System.Windows.Forms.Panel();
            this.dealerCardPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(16, 280);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(90, 16);
            this.playerScoreLabel.TabIndex = 2;
            this.playerScoreLabel.Text = "Счет игрока:";
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Location = new System.Drawing.Point(16, 43);
            this.dealerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(93, 16);
            this.dealerScoreLabel.TabIndex = 3;
            this.dealerScoreLabel.Text = "Счет дилера:";
            // 
            // playerDibsLabel
            // 
            this.playerDibsLabel.AutoSize = true;
            this.playerDibsLabel.Location = new System.Drawing.Point(931, 418);
            this.playerDibsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerDibsLabel.Name = "playerDibsLabel";
            this.playerDibsLabel.Size = new System.Drawing.Size(58, 16);
            this.playerDibsLabel.TabIndex = 4;
            this.playerDibsLabel.Text = "Баланс:";
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(19, 504);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(100, 28);
            this.hitButton.TabIndex = 5;
            this.hitButton.Text = "Взять";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(134, 504);
            this.standButton.Margin = new System.Windows.Forms.Padding(4);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(100, 28);
            this.standButton.TabIndex = 6;
            this.standButton.Text = "Хватит";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(252, 504);
            this.doubleButton.Margin = new System.Windows.Forms.Padding(4);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(100, 28);
            this.doubleButton.TabIndex = 7;
            this.doubleButton.Text = "Удвоить";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // surrenderButton
            // 
            this.surrenderButton.Location = new System.Drawing.Point(372, 504);
            this.surrenderButton.Margin = new System.Windows.Forms.Padding(4);
            this.surrenderButton.Name = "surrenderButton";
            this.surrenderButton.Size = new System.Drawing.Size(100, 28);
            this.surrenderButton.TabIndex = 8;
            this.surrenderButton.Text = "Сдаться";
            this.surrenderButton.UseVisualStyleBackColor = true;
            this.surrenderButton.Click += new System.EventHandler(this.surrenderButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(934, 469);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(100, 22);
            this.betTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите ставку";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(934, 504);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dealerCardPanel
            // 
            this.dealerCardPanel.Controls.Add(this.panel3);
            this.dealerCardPanel.Controls.Add(this.panel2);
            this.dealerCardPanel.Location = new System.Drawing.Point(19, 62);
            this.dealerCardPanel.Name = "dealerCardPanel";
            this.dealerCardPanel.Size = new System.Drawing.Size(841, 151);
            this.dealerCardPanel.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 166);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 163);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 166);
            this.panel4.TabIndex = 14;
            // 
            // playerCardPanel
            // 
            this.playerCardPanel.Location = new System.Drawing.Point(19, 299);
            this.playerCardPanel.Name = "playerCardPanel";
            this.playerCardPanel.Size = new System.Drawing.Size(841, 160);
            this.playerCardPanel.TabIndex = 14;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.playerCardPanel);
            this.Controls.Add(this.dealerCardPanel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.surrenderButton);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.playerDibsLabel);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Блэк Джек";
            this.dealerCardPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label dealerScoreLabel;
        private System.Windows.Forms.Label playerDibsLabel;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.Button surrenderButton;
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel dealerCardPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel playerCardPanel;
    }
}