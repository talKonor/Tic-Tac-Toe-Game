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
        private const int k_TileSize = 50;
        private readonly Engine r_Engine;
        private readonly List<List<BoardTile>> r_Board;
        private readonly bool r_IsGameAgainstAi;
        private int m_CurrentPlayer = 1;

        public BoardGUI(Engine i_Engine, bool i_IsGameAgainstAi)
        {
            InitializeComponent();
            r_Engine = i_Engine;
            Player1Name.Text = string.Format("{0}:", r_Engine.GetPlayer(1).PlayerName);
            Player2Name.Text = string.Format("{0}:", r_Engine.GetPlayer(2).PlayerName);
            Player1Score.Text = (r_Engine.GetPlayer(1).Score).ToString();
            Player2Score.Text = (r_Engine.GetPlayer(2).Score).ToString();
            r_IsGameAgainstAi = i_IsGameAgainstAi;
            r_Board = new List<List<BoardTile>>();
            r_Engine.m_EndGameEvent += new EndGameInvokerEventHandler(onGameEnd);
            generateBoard();
            boldCurrentPlayer();
        }

        private void generateBoard()
        {
            const int spaceBetweenTiles = 5;
            int Distance = 2;
            int startXPosition = 5;
            int startYPosition = 5;

            for (int i = 0; i < r_Engine.Board.Length; i++)
            {
                r_Board.Add(new List<BoardTile>());
                for (int j = 0; j < r_Engine.Board.Length; j++)
                {
                    r_Board[i].Add(new BoardTile(i, j, k_TileSize));
                    r_Board[i][j].Top = startXPosition + (i * k_TileSize + Distance);
                    r_Board[i][j].Left = startYPosition + (j * k_TileSize + Distance);
                    startYPosition += spaceBetweenTiles;
                    Controls.Add(r_Board[i][j]);
                    r_Board[i][j].Chosen += new ChoseInvokerEventHandler(changeBoardOnClick);
                }

                startXPosition += spaceBetweenTiles;
                startYPosition = spaceBetweenTiles;
            }

            r_Engine.SubscribeToBoardChanges(BoardGUIChangeOnBoardChange);
            Width = r_Engine.Board.Length * 55 + 10;
            Height = r_Engine.Board.Length * 55 + 65;
        }

        private void onGameEnd(Result.eEndGameStatus i_Result, int i_Player1Score, int i_Player2Score)
        {
            string message;
            string title;

            switch (i_Result)
            {
                case Result.eEndGameStatus.Tie:
                    {
                        title = "A Tie!";
                        message = String.Format("Tie!{0}", Environment.NewLine);
                        break;
                    }

                case Result.eEndGameStatus.Player1Won:
                    {
                        title = "A Win!";
                        message = String.Format("The winner is {0}!{1}", r_Engine.GetPlayer(1).PlayerName, Environment.NewLine);
                        break;
                    }

                case Result.eEndGameStatus.Player2Won:
                    {
                        title = "A Win!";
                        message = String.Format("The winner is {0}!{1}", r_Engine.GetPlayer(2).PlayerName, Environment.NewLine);
                        break;
                    }

                default:
                    {
                        title = "";
                        message = "";
                        break;
                    }
            }

            message += "Would you like to play another round?";
            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            Player1Score.Text = (r_Engine.GetPlayer(1).Score).ToString();
            Player2Score.Text = (r_Engine.GetPlayer(2).Score).ToString();
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
            r_Engine.ResetBoard();
            m_CurrentPlayer = 2;
            resetEnabledTiles();
        }

        private void resetEnabledTiles()
        {
            for (int i = 0; i < r_Engine.Board.Length; i++)
            {
                for (int j = 0; j < r_Engine.Board.Length; j++)
                {
                    r_Board[i][j].Enabled = true;
                }
            }
        }

        private void endGame()
        {
            Close();
        }

        private void changeBoardOnClick(object sender)
        {
            int moveRow = (sender as BoardTile).Row;
            int moveCol = (sender as BoardTile).Col;

            r_Engine.MakeMove(m_CurrentPlayer, moveRow, moveCol);
            endTurn();
        }

        private void endTurn()
        {
            m_CurrentPlayer = m_CurrentPlayer == 1 ? 2 : 1;
            boldCurrentPlayer();
            Refresh();
            if (r_IsGameAgainstAi && m_CurrentPlayer == 2)
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
            PlayIndex bestMove = AiPlayer.GetAiBestMove(r_Engine.GetPlayer(m_CurrentPlayer), r_Engine.Board);

            if (bestMove.m_RowNumber != -1 && bestMove.m_ColumnNumber != -1)
            {
                r_Engine.MakeMove(m_CurrentPlayer, bestMove.m_RowNumber, bestMove.m_ColumnNumber);
                string sign = (r_Engine.GetPlayer(m_CurrentPlayer).Symbol).ToString();
                (r_Board[bestMove.m_RowNumber][bestMove.m_ColumnNumber]).Text = sign;
                (r_Board[bestMove.m_RowNumber][bestMove.m_ColumnNumber]).Enabled = false;
                endTurn();
            }
        }

        private void BoardGUIChangeOnBoardChange(int i_Row, int i_Col, char i_Symbol)
        {
            r_Board[i_Row][i_Col].Text = (i_Symbol).ToString();
            r_Board[i_Row][i_Col].Enabled = false;
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
