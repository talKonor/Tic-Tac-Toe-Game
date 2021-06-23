using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Board
    {
        private char[,] m_Board;
        private int m_NumberOfEmptySpots;
       
        public Board(int i_BoardSize)
        {
            m_Board = new char[i_BoardSize, i_BoardSize];
            m_NumberOfEmptySpots = (int)Math.Pow(i_BoardSize, 2);
        }
        
        public int NumberOfEmptySpots
        {
            get 
            {
                return m_NumberOfEmptySpots; 
            }
        }
        
        public int Length
        {
            get 
            { 
                return m_Board.GetLength(0);
            }
        }
        
        private bool isEmptyCell(int i_Row, int i_Column)
        {
            return (isInBounds(i_Row, i_Column)) && (m_Board[i_Row, i_Column] == ' ');
        }
        
        private bool checkLoseRow(int i_Row, int i_Column)
        {
            bool isLose;
            char symbolToCheck = m_Board[i_Row, i_Column];
            int symbolsInARow = 1;
            int index = 1;

            while (isInBounds(i_Row - index, i_Column))
            {
                if (m_Board[i_Row - index, i_Column] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            index = 1;
            while (isInBounds(i_Row + index, i_Column))
            {
                if (m_Board[i_Row + index, i_Column] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            isLose = symbolsInARow == m_Board.GetLength(0);

            return isLose;
        }
       
        private bool checkLoseColumn(int i_Row, int i_Column)
        {
            bool isLose;
            char symbolToCheck = m_Board[i_Row, i_Column];
            int symbolsInARow = 1;
            int index = 1;

            while (isInBounds(i_Row, i_Column - index))
            {
                if (m_Board[i_Row, i_Column - index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            index = 1;
            while (isInBounds(i_Row, i_Column + index))
            {
                if (m_Board[i_Row, i_Column + index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            isLose = (symbolsInARow == m_Board.GetLength(0));

            return isLose;
        }
       
        private bool checkLoseDiagonalTopRightToBottomLeft(int i_Row, int i_Column)
        {
            bool isLose;
            char symbolToCheck = m_Board[i_Row, i_Column];
            int symbolsInARow = 1;
            int index = 1;

            while (isInBounds(i_Row - index, i_Column + index))
            {
                if (m_Board[i_Row - index, i_Column + index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            index = 1;
            while (isInBounds(i_Row + index, i_Column - index))
            {
                if (m_Board[i_Row + index, i_Column - index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            isLose = symbolsInARow == m_Board.GetLength(0);

            return isLose;
        }
        
        private bool checkLoseDiagonalTopLeftToBottomRight(int i_Row, int i_Column)
        {
            bool isLose;
            char symbolToCheck = m_Board[i_Row, i_Column];
            int symbolsInARow = 1;
            int index = 1;

            while (isInBounds(i_Row - index, i_Column - index))
            {
                if (m_Board[i_Row - index, i_Column - index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            index = 1;
            while (isInBounds(i_Row + index, i_Column + index))
            {
                if (m_Board[i_Row + index, i_Column + index] == symbolToCheck)
                {
                    symbolsInARow++;
                    index++;
                }
                else
                {
                    break;
                }
            }

            isLose = symbolsInARow == m_Board.GetLength(0);

            return isLose;
        }

        public bool CheckLose(int i_Row, int i_Column)
        {
            return checkLoseRow(i_Row, i_Column) || checkLoseColumn(i_Row, i_Column) || checkLoseDiagonalTopRightToBottomLeft(i_Row, i_Column)
                   || checkLoseDiagonalTopLeftToBottomRight(i_Row, i_Column);
        }
       
        public Result AddMove(Player i_Player, int i_Row, int i_Column)
        {
            Result resultOfMove;

            if (!isInBounds(i_Row, i_Column))
            {
                resultOfMove = new Result(Result.eEndGameStatus.NotOver, false, "Move was out of bounds");
            }

            else if (!isEmptyCell(i_Row, i_Column))
            {
                resultOfMove = new Result(Result.eEndGameStatus.NotOver, false, "Cell is taken");
            }
            else
            {
                SetCell(i_Row, i_Column, i_Player.Symbol);
                if (CheckLose(i_Row, i_Column))
                {
                    if (i_Player.PlayerNumber == 1)
                    {
                        resultOfMove = new Result(Result.eEndGameStatus.Player2Won, true, String.Format("Player {0} lost", i_Player.PlayerNumber));
                    }
                    else
                    {
                        resultOfMove = new Result(Result.eEndGameStatus.Player1Won, true, String.Format("Player {0} lost", i_Player.PlayerNumber));
                    }
                }
                else
                {
                    if (m_NumberOfEmptySpots == 0)
                    {
                        resultOfMove = new Result(Result.eEndGameStatus.Tie, true, "");
                    }
                    else
                    {
                        resultOfMove = new Result(Result.eEndGameStatus.NotOver, true, "");
                    }
                }
            }

            return resultOfMove;
        }
        
        public void ResetBoard()
        {
            for (int i = 0; i < m_Board.GetLength(0); i++)
            {
                for (int j = 0; j < m_Board.GetLength(0); j++)
                {
                    m_Board[i, j] = ' ';
                }
            }
        }
       
        public override string ToString()
        {
            StringBuilder boardAsString = new StringBuilder((m_Board.GetLength(0) + 1) * (m_Board.GetLength(1) + 1));

            boardAsString.Append(Environment.NewLine);
            for (int i = 0; i < m_Board.GetLength(0); i++)
            {
                boardAsString.AppendFormat("   {0}", i + 1);
            }

            boardAsString.Append(Environment.NewLine);
            for (int i = 0; i < m_Board.GetLength(0); i++)
            {
                boardAsString.AppendFormat("{0}|", i + 1);
                for (int j = 0; j < m_Board.GetLength(0); j++)
                {
                    boardAsString.AppendFormat(" {0} |", m_Board[i, j]);
                }
                boardAsString.Append(Environment.NewLine);
                boardAsString.Append(' ', 2);
                boardAsString.Append('=', 4 * m_Board.GetLength(0));
                boardAsString.Append(Environment.NewLine);
            }

            return boardAsString.ToString();
        }
        
        public bool SetCell(int i_Row, int i_Column, char i_Symbol)
        {
            bool isSetMethodWorked;

            if (isInBounds(i_Row, i_Column))
            {
                m_Board[i_Row, i_Column] = i_Symbol;
                if (i_Symbol != ' ')
                {
                    m_NumberOfEmptySpots--;
                }
                else
                {
                    m_NumberOfEmptySpots++;
                }
                isSetMethodWorked = true;
            }
            else
            {
                isSetMethodWorked = false;

            }

            return isSetMethodWorked;
        }
        
        public char GetCell(int i_Row, int i_Column)
        {
            char charToReturn;

            if (isInBounds(i_Row, i_Column))
            {
                charToReturn = m_Board[i_Row, i_Column];
            }
            else
            {
                charToReturn = 'E';
            }

            return charToReturn;
        }
        
        private bool isInBounds(int i_Row, int i_Column)
        {
            return (i_Row >= 0 && i_Row < m_Board.GetLength(0)) && (i_Column >= 0 && i_Column < m_Board.GetLength(0));
        }
       
        public Board Clone()
        {
            Board boardToReturn = new Board(m_Board.Length);

            boardToReturn.m_Board = (char[,])m_Board.Clone();
            boardToReturn.m_NumberOfEmptySpots = m_NumberOfEmptySpots;

            return boardToReturn;
        }
    }
}
