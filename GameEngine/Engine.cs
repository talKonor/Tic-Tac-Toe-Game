using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Engine
    {
        private readonly Board m_Board;
        private readonly Player m_Player1;
        private readonly Player m_Player2;

        public Board Board
        {
            get
            {                                      
                return m_Board.Clone();
            }
        }
        
        public Engine(int i_BoardSize, char i_Player1Symbol, char i_Player2Symbol)
        {
            m_Board = new Board(i_BoardSize);
            m_Player1 = new Player(1, i_Player1Symbol);
            m_Player2 = new Player(2, i_Player2Symbol);
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
        
            return whatHappened;
        }

        public string GetScoresAsString()
        {
            return String.Format(("Player {0} Score: {1}  |  Player {2} Score: {3}"), m_Player1.Symbol, m_Player1.Score, m_Player2.Symbol, m_Player2.Score);
        }
    }
}
