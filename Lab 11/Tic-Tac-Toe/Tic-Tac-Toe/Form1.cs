using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string winner;
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            textBoxP1Score.Text = "0";
            textBoxP2Score.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Turn())
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }

            if(isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if(winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if(winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if(isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        bool Turn()
        {
            int count = 1;
            foreach(Button button in buttons)
            {
                if(button.Text != "")
                {
                    count++;
                }

            }
            if(count % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void Clear()
        {
            foreach(Button button in buttons)
            {
                button.Text = string.Empty;
            }
        }

        bool isDraw()
        {
            int count = 0;
            foreach(Button button in  buttons)
            {
                if (button.Text != "")
                    count++;
            }
            if(count == 9 && !isWin())
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Turn())
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            if (isWin())
            {
                int score1 = int.Parse(textBoxP1Score.Text);
                int score2 = int.Parse(textBoxP2Score.Text);
                if (winner == "p1")
                {
                    score1 += 1;
                    MessageBox.Show("Player1 has Won!");
                    textBoxP1Score.Text = score1.ToString();
                    Clear();
                }
                else if (winner == "p2")
                {
                    score2 += 1;
                    MessageBox.Show("Player2 has won!");
                    textBoxP2Score.Text = score2.ToString();
                    Clear();
                }
            }
            if (isDraw())
            {
                MessageBox.Show("GAME DRAW!!");
                Clear();
            }
        }

        bool isWin()
        {
            int count1 = 0;
            int count2 = 0;
            for(int i=0; i<3; i++)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if(count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if(count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 3; i < 6; i++)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 6; i < 9; i++)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 0; i < 7; i+=3)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 1; i < 8; i += 3)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 2; i < 9; i += 3)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 0; i < 9; i += 4)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 2; i < 7; i += 2)
            {
                if (buttons[i].Text == "X")
                    count1++;
                if (buttons[i].Text == "O")
                    count2++;
            }
            if (count1 == 3)
            {
                winner = "p2";
                return true;
            }
            else if (count2 == 3)
            {
                winner = "p1";
                return true;
            }
            return false;

        }
    }
}
