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
        private bool m_IsAi;
        private Engine m_Engine;
        
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

        private void checkBoxIsHuman_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2Name.Enabled)
            {
                Player2Name.Text = "[Computer]";
            }
            else
            {
                Player2Name.Text = "";
            }

            Player2Name.Enabled = !Player2Name.Enabled;
            m_IsAi = Player2Name.Enabled;
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            ColNumber.Value = RowNumber.Value;
        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            RowNumber.Value = ColNumber.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int boardSize = Convert.ToInt32(RowNumber.Value);
            string player1Name = Player1Name.Text;
            string player2Name;
            
            if (!CheckBoxIsHuman.Checked)
            {
                player2Name = "Computer";
            }
            else
            {
                player2Name = Player2Name.Text;
            }
            
            m_Engine = new Engine(boardSize, player1Name, player2Name);
            m_IsAi = !CheckBoxIsHuman.Checked;
            Close();
        }

        private void Player1Name_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelPlayers_Click(object sender, EventArgs e)
        {
        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {
        }

        private void labelRows_Click(object sender, EventArgs e)
        {
        }
    }
}
