using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Player
    {
        private string m_PlayerName;
        private int m_PlayerNumber;
        private char m_Symbol;
        private int m_Score;

        public Player(string i_PlayerName,int i_PlayerNumber, char i_Symbol)
        {
            m_PlayerName = i_PlayerName;
            m_PlayerNumber = i_PlayerNumber;
            m_Symbol = i_Symbol;
            m_Score = 0;
        }

        public char Symbol
        {
            get
            {
                return m_Symbol;
            }

            set
            {
                m_Symbol = value;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                m_Score = value;
            }
        }

        public int PlayerNumber
        {
            get
            {
                return m_PlayerNumber;
            }

            set
            {
                m_PlayerNumber = value;
            }
        }
        public string PlayerName
        {
            get
            {
                return m_PlayerName;
            }

            set
            {
                m_PlayerName = value;
            }
        }

    }
}
