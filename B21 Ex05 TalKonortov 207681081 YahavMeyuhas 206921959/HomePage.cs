using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine;

namespace GUI
{
    public partial class HomePage : Form
    {
        bool m_IsAi;
        Engine m_Engine;
        public HomePage()
        {
            InitializeComponent();
        }

        public bool IsAi
        {
            get 
            { 
                return m_IsAi;
            }
        }
        public Engine Engine
        {
            get
            {
                return m_Engine;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2Name.Enabled)
            {
                Player2Name.Text ="[Computer]";
            }
            else
            {
                Player2Name.Text = "";
            }
            Player2Name.Enabled = !Player2Name.Enabled;
            m_IsAi = Player2Name.Enabled;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ColNumber.Value = RowNumber.Value;
        }

        private void ColNumber_ValueChanged(object sender, EventArgs e)
        {
            RowNumber.Value = ColNumber.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int boardSize = (int)RowNumber.Value;
            string player1Name = Player1Name.Text;
            string player2Name = Player2Name.Text;
            m_Engine = new Engine(boardSize, player1Name, player2Name);
            m_IsAi = !CheckBoxIsHuman.Checked;
            this.Close();
        }

        private void Player1Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
