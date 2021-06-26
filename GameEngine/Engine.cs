using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public delegate void EndGameInvokerEventHandler(Result.eEndGameStatus i_WhoWon,int i_Player1Score, int i_Player2Score);
    public class Engine
    {
        private Board m_Board;
        private Player m_Player1;
        private Player m_Player2;
        public event EndGameInvokerEventHandler m_EndGameEvent;
        public Board Board
        {
            get
            {                                      
                return m_Board.Clone();
            }
        }


        public Engine()
        {

        }
        public char getCurrentPlayerChar(int curr)
        {
            return ' ';
        }
        public Engine(int i_BoardSize, string i_Player1Name, string i_Player2Name)
        {
            Init(i_BoardSize, i_Player1Name, i_Player2Name);
        }
        public void Init(int i_BoardSize, string i_Player1Name, string i_Player2Name)
        {
            m_Board = new Board(i_BoardSize);
            m_Player1 = new Player(i_Player1Name,1, 'X');
            m_Player2 = new Player(i_Player2Name,2, 'O');
        }
       
        public void ResetBoard()
        {
            m_Board.ResetBoard();
        }

        public Player GetPlayer(int i_playerNumber)
        {
            Player playerToReturn=null;

            if(i_playerNumber == 1)
            {
                playerToReturn= m_Player1;
            }
            if (i_playerNumber == 2)
            {
                playerToReturn = m_Player2;
            }

            return playerToReturn;
        }
        
        public Result MakeMove(int i_PlayerNumber, int i_Row, int i_Column)
        {
            Player playerToMakeMove = GetPlayer(i_PlayerNumber);
            Result whatHappened = m_Board.AddMove(playerToMakeMove, i_Row, i_Column);

            if (whatHappened.EndGameStatus == Result.eEndGameStatus.Player1Won)
            {
                m_Player1.Score++;
            }
            if (whatHappened.EndGameStatus == Result.eEndGameStatus.Player2Won)
            {
                m_Player2.Score++;
            }
            if(whatHappened.EndGameStatus != Result.eEndGameStatus.NotOver)
            {
                if (m_EndGameEvent != null)
                {
                    m_EndGameEvent.Invoke(whatHappened.EndGameStatus, m_Player1.Score, m_Player2.Score);
                }
            }
            return whatHappened;
        }

        public string GetScoresAsString()
        {
            return String.Format(("Player {0} Score: {1}  |  Player {2} Score: {3}"), m_Player1.Symbol, m_Player1.Score, m_Player2.Symbol, m_Player2.Score);
        }

        public void SubscribeToBoardChanges(BoardChangeInvokerEventHandler i_OnBoardChangeFunction) 
        {
            m_Board.BoardChangeEvent += i_OnBoardChangeFunction;
        }
    }
}
