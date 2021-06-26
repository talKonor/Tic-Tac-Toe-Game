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
using System.Collections;


namespace GUI
{
    public partial class BoardGUI : Form
    {
        Engine m_Engine;
        List<List<BoardTile>> m_Board;
        int m_CurrentPlayer = 1;
        bool m_IsGameAgainstAi;
        public BoardGUI(Engine i_Engine, bool i_IsGameAgainstAi)
        {
            m_Engine = i_Engine;
            InitializeComponent();
            Player1Name.Text = string.Format("{0}:", m_Engine.GetPlayer(1).PlayerName);
            Player2Name.Text = string.Format("{0}:", m_Engine.GetPlayer(2).PlayerName);
            Player1Score.Text = (m_Engine.GetPlayer(1).Score).ToString();
            Player2Score.Text = (m_Engine.GetPlayer(2).Score).ToString();
            m_IsGameAgainstAi = i_IsGameAgainstAi;
            m_Board = new List<List<BoardTile>>();
            m_Engine.m_EndGameEvent += new EndGameInvokerEventHandler(onGameEnd);

            generateBoard();
            boldCurrentPlayer();
        }

        private void generateBoard()
        {
            int ButtonWidth = 50;
            int ButtonHeight = 50;
            int Distance = 2;
            int startXPosition = 5;
            int startYPosition = 5;

            for (int i = 0; i < m_Engine.Board.Length; i++)
            {
                m_Board.Add(new List<BoardTile>());
                for (int j = 0; j < m_Engine.Board.Length; j++)
                {
                    m_Board[i].Add(new BoardTile(m_Engine, i, j));
                    m_Board[i][j].Top = startXPosition + (i * ButtonHeight + Distance);
                    m_Board[i][j].Left = startYPosition + (j * ButtonWidth + Distance);
                    m_Board[i][j].Width = ButtonWidth;
                    m_Board[i][j].Height = ButtonHeight;
                    startYPosition += 5;
                    this.Controls.Add(m_Board[i][j]);
                    m_Board[i][j].m_Chosen += new ChoseInvokerEventHandler(changeBoardOnClick);
                }
                startXPosition += 5;
                startYPosition = 5;
            }

            m_Engine.SubscribeToBoardChanges(BoardGUIChangeOnBoardChange);
            this.Width = m_Engine.Board.Length * 55 + 10;
            this.Height = m_Engine.Board.Length * 55 + 65;
        }

        private void onGameEnd(Result.eEndGameStatus i_Result, int i_Player1Score, int i_Player2Score)
        {
            string message;
            switch (i_Result)
            {
                case Result.eEndGameStatus.Tie:
                    {
                        message = String.Format("Tie!{0}", Environment.NewLine);
                        break;
                    }
                case Result.eEndGameStatus.Player1Won:
                    {
                        message = String.Format("The winner is {0}!{1}", m_Engine.GetPlayer(1).PlayerName, Environment.NewLine);
                        break;
                    }
                case Result.eEndGameStatus.Player2Won:
                    {
                        message = String.Format("The winner is {0}!{1}", m_Engine.GetPlayer(2).PlayerName, Environment.NewLine);
                        break;
                    }
                default:
                    message = "";
                    break;
                   
            }
            message += "Would you like to play another round?";
            Player1Score.Text = (m_Engine.GetPlayer(1).Score).ToString();
            Player2Score.Text = (m_Engine.GetPlayer(2).Score).ToString();
            DialogResult dialogResult = MessageBox.Show(message, "Game Over", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetBoard();
            }
            if (dialogResult == DialogResult.No)
            {
                endGame();
            }
        }

        private void resetBoard()
        {
            m_Engine.ResetBoard();
            m_CurrentPlayer = 2;
            resetEnabledTiles();
        }

        private void resetEnabledTiles()
        {
            for (int i = 0; i < m_Engine.Board.Length; i++)
            {
                for (int j = 0; j < m_Engine.Board.Length; j++)
                {
                    m_Board[i][j].Enabled = true;
                }
            }
        }
        private void endGame()
        {
            this.Close();

        }
        private void changeBoardOnClick(object sender)
        { 
            int moveRow = (sender as BoardTile).Row;
            int moveCol = (sender as BoardTile).Col;
            string sign = (m_Engine.GetPlayer(m_CurrentPlayer).Symbol).ToString();
            m_Engine.MakeMove(m_CurrentPlayer, moveRow, moveCol);
            endTurn();
        }

        private void endTurn()
        {
            m_CurrentPlayer = m_CurrentPlayer == 1 ? 2 : 1;
            boldCurrentPlayer();
            this.Refresh();
            if (m_IsGameAgainstAi && m_CurrentPlayer == 2)
            {
                newAiTurn();
            }
        }

        private void boldCurrentPlayer()
        {
            if (m_CurrentPlayer == 1)
            {
                Player1Name.Font = new Font(Player1Name.Font, FontStyle.Bold);
                Player1Score.Font = new Font(Player1Name.Font, FontStyle.Bold);
                Player2Name.Font = new Font(Player2Name.Font, FontStyle.Regular);
                Player2Score.Font = new Font(Player2Name.Font, FontStyle.Regular);
            }
            else if (m_CurrentPlayer == 2)
            {
                Player2Name.Font = new Font(Player2Name.Font, FontStyle.Bold);
                Player2Score.Font = new Font(Player2Name.Font, FontStyle.Bold);
                Player1Name.Font = new Font(Player1Name.Font, FontStyle.Regular);
                Player1Score.Font = new Font(Player1Name.Font, FontStyle.Regular);
            }
        }

        private void newAiTurn()
        {
            PlayIndex bestMove = AiPlayer.GetAiBestMove(m_Engine.GetPlayer(m_CurrentPlayer), m_Engine.Board);
            
            if (bestMove.m_RowNumber != -1 && bestMove.m_ColumnNumber != -1)
            {
                m_Engine.MakeMove(m_CurrentPlayer, bestMove.m_RowNumber, bestMove.m_ColumnNumber);
                string sign = (m_Engine.GetPlayer(m_CurrentPlayer).Symbol).ToString();
                (m_Board[bestMove.m_RowNumber][bestMove.m_ColumnNumber]).Text = sign;
                (m_Board[bestMove.m_RowNumber][bestMove.m_ColumnNumber]).Enabled = false;
                endTurn();
            }
        }

        private void BoardGUIChangeOnBoardChange(int i_Row, int i_Col, char i_Symbol)
        {
            m_Board[i_Row][i_Col].Text =(i_Symbol).ToString();
            m_Board[i_Row][i_Col].Enabled = false;
        }

        private void BoardGUI_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Player1Name_Click(object sender, EventArgs e)
        {

        }
    }
}
