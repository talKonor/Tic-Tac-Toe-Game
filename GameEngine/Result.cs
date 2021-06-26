using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Result
    {
        private readonly eEndGameStatus m_EndGameStatus;
        private readonly bool m_WasLegalMove;
        private readonly string m_Message;

        public enum eEndGameStatus
        {
            NotOver=-1,
            Player1Won=1,
            Player2Won=2,
            Tie=0
        }

        public Result(eEndGameStatus i_EndGameStatus, bool i_WasLegalMove, string i_Message)
        {
            m_EndGameStatus = i_EndGameStatus;
            m_WasLegalMove = i_WasLegalMove;
            m_Message = i_Message;
        }

        public eEndGameStatus EndGameStatus
        {
            get
            {
                return m_EndGameStatus;
            }
        }

        public bool WasLegalMove
        {
            get
            {
                return m_WasLegalMove;
            }
        }

        public string Message
        {
            get
            {
                return m_Message;
            }
        }

    }
}
