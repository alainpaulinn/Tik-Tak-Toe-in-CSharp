using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_TicTacToe_Alain.Properties;

namespace New_TicTacToe_Alain
{
    public partial class History_HighScores : Form
    {
        Form1 form = new Form1();
        
        public History_HighScores()
        {
            InitializeComponent();
            
            
            //foreach (string[] gameresult in form. ScoresList)
            //{
            //    for (int x = 0; x < gameresult.Length; x++)
            //    {
            //        ListViewItem row = new ListViewItem(gameresult[0]);
            //        //row.SubItems.Add(Form1.player1Name);
            //        row.SubItems.Add(gameresult[1]);
            //        row.SubItems.Add(gameresult[2]);
            //        listView1.Items.Add(row);
            //    }
            //}
        }

    }
}
