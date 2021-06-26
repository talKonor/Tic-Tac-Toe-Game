using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameEngine
{
    public static class AiPlayer
    {
        enum eScoreType
        {
            Win = 10,
            Lose = -10,
            Tie = 0,
            NoScore = 11
        }

        private const int k_SmallBoard = 3;
        private const int k_MediumBoard = 5;
        private const int k_LargeBoard = 8;
        private const int k_StepsForSmallBoard = 8;
        private const int k_StepsForMediumBoard = 4;
        private const int k_StepsForLargeBoard = 3;
        private const int k_StepsForXLargeBoard = 2;

        private static int setNumberOfSteps(int i_BoardSize)
        {
            int numberOfSteps;

            if (i_BoardSize <= k_SmallBoard)
            {
                numberOfSteps = k_StepsForSmallBoard;
            }
            else
            {
                if (i_BoardSize <= k_MediumBoard)
                {
                    numberOfSteps = k_StepsForMediumBoard;
                }
                else
                {
                    if (i_BoardSize <= k_LargeBoard)
                    {
                        numberOfSteps = k_StepsForLargeBoard;
                    }
                    else
                    {
                        numberOfSteps = k_StepsForXLargeBoard;
                    }
                }
            }
            return numberOfSteps;
        }

        public static PlayIndex GetAiBestMove(Player i_Player, Board i_Board)
        {
            int bestScore = int.MinValue;
            PlayIndex bestMove;
            bestMove.m_RowNumber = -1;
            bestMove.m_ColumnNumber = -1;
            int score;
            int numberOfSteps = setNumberOfSteps(i_Board.Length);

            for (int i = 0; i < i_Board.Length; i++)
            {
                for (int j = 0; j < i_Board.Length; j++)
                {
                    if (i_Board.GetCell(i, j) == ' ')
                    {
                        i_Board.SetCell(i, j, i_Player.Symbol);
                        score = miniMax(i_Player, i_Board, numberOfSteps, false, i, j);
                        i_Board.SetCell(i, j, ' ');
                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove.m_RowNumber = i;
                            bestMove.m_ColumnNumber = j;
                        }
                    }
                }
            }

            return bestMove;
        }

        private static int miniMax(Player i_Player, Board i_Board, int i_Depth, bool i_IsMaximizing, int i_RowIndex, int i_ColumnIndex)
        {
            int bestScore;
            int score = 0;
            int result = checkWin(i_Board, i_RowIndex, i_ColumnIndex);
            if (result != 11 || i_Depth <= 0)
            {
                bestScore = result;
            }
            else
            {
                if (i_IsMaximizing)
                {
                    bestScore = int.MaxValue;
                    for (int i = 0; i < i_Board.Length; i++)
                    {
                        for (int j = 0; j < i_Board.Length; j++)
                        {
                            if (i_Board.GetCell(i, j) == ' ')
                            {
                                i_Board.SetCell(i, j, i_Player.Symbol);
                                score += miniMax(i_Player, i_Board, i_Depth - 1, false, i, j);
                                i_Board.SetCell(i, j, ' ');
                                bestScore = Math.Min(score, bestScore);
                            }
                        }
                    }
                }
                else
                {
                    bestScore = int.MinValue;
                    for (int i = 0; i < i_Board.Length; i++)
                    {
                        for (int j = 0; j < i_Board.Length; j++)
                        {
                            if (i_Board.GetCell(i, j) == ' ')
                            {
                                i_Board.SetCell(i, j, i_Player.Symbol == 'O' ? 'X' : 'O');
                                score += miniMax(i_Player, i_Board, i_Depth - 1, true, i, j);
                                i_Board.SetCell(i, j, ' ');
                                bestScore = Math.Max(score, bestScore);

                            }
                        }
                    }
                }
            }

            return bestScore;
        }

        private static int checkWin(Board i_Board, int i_RowIndex, int i_ColumnIndex)
        {
            int scoreToReturn = (int)eScoreType.Tie;
            if (i_Board.CheckLose(i_RowIndex, i_ColumnIndex))
            {
                if (i_Board.GetCell(i_RowIndex, i_ColumnIndex) == 'X')
                {
                    scoreToReturn = (int)eScoreType.Win;
                }
                else
                {
                    scoreToReturn = (int)eScoreType.Lose;
                }
            }
            else
            {
                char secondSymbol = i_Board.GetCell(i_RowIndex, i_ColumnIndex) == 'O' ? 'X' : 'O';
                i_Board.SetCell(i_RowIndex, i_ColumnIndex, ' ');
                i_Board.SetCell(i_RowIndex, i_ColumnIndex, secondSymbol);
                if (i_Board.CheckLose(i_RowIndex, i_ColumnIndex))
                {
                    if (i_Board.GetCell(i_RowIndex, i_ColumnIndex) == 'X')
                    {
                        scoreToReturn = (int)eScoreType.Win;
                    }
                    else
                    {
                        scoreToReturn = (int)eScoreType.Lose;
                    }
                }
                else
                {
                    if (i_Board.NumberOfEmptySpots != 0 && scoreToReturn == 0)
                    {
                        scoreToReturn = (int)eScoreType.NoScore;
                    }
                }
            }

            i_Board.SetCell(i_RowIndex, i_ColumnIndex, i_Board.GetCell(i_RowIndex, i_ColumnIndex) == 'O' ? 'X' : 'O');

            return scoreToReturn;
        }
    }
}
