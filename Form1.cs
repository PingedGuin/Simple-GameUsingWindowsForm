using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplicationGame.Properties;

namespace WindowsApplicationGame
{
    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enPlayer enPlayerTurn = enPlayer.Player1;


        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void ChangeImage(PictureBox button)
        {
            if (button.Tag.ToString() == "?")
            {
                switch (enPlayerTurn)
                {
                    case enPlayer.Player1:
                        button.Image = Resources._91c8257e_ed15_4dc4_ab8c_b6c1e296b6a4;
                        enPlayerTurn = enPlayer.Player2;
                        lbPlayerTurn.Text = "Player 2";
                        button.Tag = "x";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                     case enPlayer.Player2:
                        button.Image = Resources.fef21613_24d9_43ba_b1f7_cce5d19af77e;
                        enPlayerTurn = enPlayer.Player1;
                        lbPlayerTurn.Text = "Player 1";
                        button.Tag = "y";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong chice","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;  
                EndGame();
            }
        }
        public void CheckWinner()
        {
            if (cheackValue(pic1, pic2, pic3))
                return;

            if (cheackValue(pic4, pic5, pic6))
                return;

            if (cheackValue(pic7, pic8, pic9))
                return;

            if (cheackValue(pic1, pic4, pic7))
                return;

            if (cheackValue(pic2, pic5, pic8))
                return;

            if (cheackValue(pic3, pic6, pic9))
                return;

            if (cheackValue(pic1, pic5, pic9))
                return;

            if (cheackValue(pic3, pic5, pic7))
                return;
        }

        public bool cheackValue(PictureBox element1,PictureBox element2,PictureBox element3)
        {
            if (element1.Tag.ToString() != "?" && element1.Tag.ToString() == element2.Tag.ToString() && element1.Tag.ToString() == element3.Tag.ToString())
            {
                element1.BackColor = Color.GreenYellow;
                element2.BackColor = Color.GreenYellow;
                element3.BackColor = Color.GreenYellow;

                if (element1.Tag.ToString() == "x")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }       
        void EndGame()
        {
            lbPlayerTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lbWinnerIs.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lbWinnerIs.Text = "Player 2";
                    break;
                default:
                    lbWinnerIs.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void RestButton(PictureBox element)
        {
            element.Image = Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            element.Tag = "?";
            element.BackColor = Color.Transparent;
        }
        void RestartGame()
        {
            RestButton(pic1); 
            RestButton(pic2);
            RestButton(pic3);
            RestButton(pic4);
            RestButton(pic5);
            RestButton(pic6);
            RestButton(pic7);
            RestButton(pic8);
            RestButton(pic9);

            enPlayerTurn = enPlayer.Player1;
            lbPlayerTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            lbWinnerIs.Text = " in Progress";

        }
        private void Button_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
