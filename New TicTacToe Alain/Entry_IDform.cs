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
    public partial class Entry_IDform : Form
    {
        public Entry_IDform()
        {
            InitializeComponent();
        }

        private void IntoduceComputer(object sender, EventArgs e)
        {
            textBox2.Text = "Computer";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.passTheIDs(textBox1.Text, textBox2.Text);
            if (textBox2.Text.ToLower() == "computer") { Form1.computerMode = true; } else { Form1.computerMode = false; }
            this.Close();
        }
    }
}
