using New_TicTacToe_Alain.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_TicTacToe_Alain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string player1Name, player2Name, winnerName;
        public static int payer1goals, player2goals = 0;
        private static bool turn = true;
        private static bool userWin = false;
        public static bool computerMode;
        private static int drawcount = 0;
        //public List<string[]> ScoresList;
        //History_HighScores history = new New_TicTacToe_Alain.History_HighScores();


        private void BtnA1_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if (!computerMode)
            {
                if (turn)
                {
                    a.Text = "O";
                    a.Enabled = false;
                    CheckforWin();
                    turn = !turn;
                }
                else if (!turn)
                {
                    a.Text = "X";
                    a.Enabled = false;
                    CheckforWin();
                    turn = !turn;
                }
            }
            if (computerMode)
            {
                NewMethod(a);
                if (!userWin)
                {
                    ComputerPlayNow();
                    CheckforWin();

                }
                turn = !turn;

            }



        }

        private void NewMethod(Button a)
        {
            if (turn)
            {
                a.Text = "O";
                a.Enabled = false;
                CheckforWin();
                turn = !turn;
            }
        }

        private void CheckforWin()
        {
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && !btnA1.Enabled)
                userWin = true;
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && !btnB1.Enabled)
                userWin = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && !btnC1.Enabled)
                userWin = true;

            else if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && !btnA1.Enabled)
                userWin = true;
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && !btnA2.Enabled)
                userWin = true;
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && !btnA3.Enabled)
                userWin = true;

            else if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && !btnA1.Enabled)
                userWin = true;
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && !btnA3.Enabled)
                userWin = true;
            drawcount++;

            if (userWin)
                switch (turn)
                {
                    case true:
                        DisableBtns();
                        MessageBox.Show($"{player1Name}Won!!", "results");
                        ListViewItem item = new ListViewItem(player1Name);
                        player1Name = winnerName;
                        //string[] prewinners1 = { player1Name, player2Name, player1Name };
                        //ScoresList.Add(prewinners1);

                        break;
                    case false:
                        DisableBtns();
                        MessageBox.Show($"{player2Name}Won!!", "results");
                        player2Name = winnerName;
                        //string[] prewinners2 = { player1Name, player2Name, player2Name };
                        //ScoresList.Add(prewinners2);

                        break;
                }
            else if (drawcount == 9) { DisableBtns(); MessageBox.Show("This is a draw try again", "Draw"); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entry_IDform entry_IDform = new Entry_IDform();
            entry_IDform.ShowDialog();

        }
        public static void passTheIDs(string player1, string player2)
        {
            player1Name = player1;
            player2Name = player2;
        }

        private void DisableBtns()
        {
            foreach (Button b in this.Controls.OfType<Button>()) { b.Enabled = false; }
        }
        private void ComputerPlayNow()
        {
            if ((btnA1.Text == btnA2.Text) && (btnA1.Text != "") && (btnA3.Enabled == true)) { Mark(btnA3); }        // horisontal check
            else if ((btnA1.Text == btnA3.Text) && (btnA1.Text != "") && (btnA2.Enabled == true)) { Mark(btnA2); }        // horisontal check
            else if ((btnA2.Text == btnA3.Text) && (btnA2.Text != "") && (btnA1.Enabled == true)) { Mark(btnA1); }        // horisontal check

            else if ((btnB1.Text == btnB2.Text) && (btnB1.Text != "") && (btnB3.Enabled == true)) { Mark(btnB3); }        // horisontal check
            else if ((btnB1.Text == btnB3.Text) && (btnB1.Text != "") && (btnB2.Enabled == true)) { Mark(btnB2); }        // horisontal check
            else if ((btnB2.Text == btnB3.Text) && (btnB2.Text != "") && (btnB1.Enabled == true)) { Mark(btnB1); }        // horisontal check

            else if ((btnC1.Text == btnC2.Text) && (btnC1.Text != "") && (btnC3.Enabled == true)) { Mark(btnC3); }        // horisontal check
            else if ((btnC1.Text == btnC3.Text) && (btnC1.Text != "") && (btnC2.Enabled == true)) { Mark(btnC2); }        // horisontal check
            else if ((btnC2.Text == btnC3.Text) && (btnC2.Text != "") && (btnC1.Enabled == true)) { Mark(btnC1); }        // horisontal check


            else if ((btnA1.Text == btnB1.Text) && (btnA1.Text != "") && (btnC1.Enabled == true)) { Mark(btnC1); }        // vertical check
            else if ((btnA1.Text == btnC1.Text) && (btnA1.Text != "") && (btnB1.Enabled == true)) { Mark(btnB1); }        // vertical check
            else if ((btnC1.Text == btnB1.Text) && (btnC1.Text != "") && (btnA1.Enabled == true)) { Mark(btnA1); }        // vertical check

            else if ((btnA2.Text == btnB2.Text) && (btnA2.Text != "") && (btnC2.Enabled == true)) { Mark(btnC2); }        // vertical check
            else if ((btnA2.Text == btnC2.Text) && (btnA2.Text != "") && (btnB2.Enabled == true)) { Mark(btnB2); }        // vertical check
            else if ((btnC2.Text == btnB2.Text) && (btnC2.Text != "") && (btnA2.Enabled == true)) { Mark(btnA2); }        // vertical check

            else if ((btnA3.Text == btnB1.Text) && (btnA3.Text != "") && (btnC3.Enabled == true)) { Mark(btnC3); }        // vertical check
            else if ((btnA3.Text == btnC1.Text) && (btnA3.Text != "") && (btnB3.Enabled == true)) { Mark(btnB3); }        // vertical check
            else if ((btnC3.Text == btnB1.Text) && (btnC3.Text != "") && (btnA3.Enabled == true)) { Mark(btnA3); }        // vertical check



            else if ((btnA1.Text == btnB2.Text) && (btnA1.Text != "") && (btnC3.Enabled == true)) { Mark(btnC3); }        // oblique check
            else if ((btnA1.Text == btnC3.Text) && (btnA1.Text != "") && (btnB2.Enabled == true)) { Mark(btnB2); }        // oblique check
            else if ((btnB2.Text == btnC3.Text) && (btnB2.Text != "") && (btnA1.Enabled == true)) { Mark(btnA1); }        // oblique check

            else if ((btnA3.Text == btnB2.Text) && (btnA3.Text != "") && (btnC1.Enabled == true)) { Mark(btnC1); }        // oblique check
            else if ((btnA3.Text == btnC1.Text) && (btnA3.Text != "") && (btnB2.Enabled == true)) { Mark(btnB2); }        // oblique check
            else if ((btnB2.Text == btnC1.Text) && (btnB2.Text != "") && (btnA3.Enabled == true)) { Mark(btnA3); }        // oblique check
            //----------------------------------------end of win or block
            else if (btnA1.Text == "") { Mark(btnA1); }
            else if (btnA3.Text == "") { Mark(btnA3); }
            else if (btnC1.Text == "") { Mark(btnC1); }
            else if (btnC3.Text == "") { Mark(btnC3); }
            //---------------------------END OF TAKING CORNER
            else if (btnB2.Text == "") { }

            else if (btnA2.Text == "") { Mark(btnA2); }
            else if (btnB1.Text == "") { Mark(btnB1); }
            else if (btnC2.Text == "") { Mark(btnC2); }
            else if (btnB3.Text == "") { Mark(btnB3); }
            // PICK OPEN SPACE

        }

        private void HighScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_HighScores history_ = new History_HighScores();

            history_.Show();
        }


        private void ComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computerMode = !computerMode;
        }

        private void Mark(Button b)
        {
            b.Text = "X";
            b.Enabled = false;
        }
        private void QuickNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Button a in this.Controls.OfType<Button>()) { a.Enabled = true; a.Text = ""; }
            drawcount = 0;
            userWin = false;
        }

    }
}
