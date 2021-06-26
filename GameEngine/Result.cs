using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Result
    {
        private readonly eEndGameStatus r_EndGameStatus;
        private readonly bool r_WasLegalMove;
        private readonly string r_Message;

        public enum eEndGameStatus
        {
            NotOver=-1,
            Player1Won=1,
            Player2Won=2,
            Tie=0
        }

        public Result(eEndGameStatus i_EndGameStatus, bool i_WasLegalMove, string i_Message)
        {
            r_EndGameStatus = i_EndGameStatus;
            r_WasLegalMove = i_WasLegalMove;
            r_Message = i_Message;
        }

        public eEndGameStatus EndGameStatus
        {
            get
            {
                return r_EndGameStatus;
            }
        }

        public bool WasLegalMove
        {
            get
            {
                return r_WasLegalMove;
            }
        }

        public string Message
        {
            get
            {
                return r_Message;
            }
        }

    }
}
