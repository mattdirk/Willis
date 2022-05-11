using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe : ITicTacToe
    {
        int boardSize = 0;
        int[] board = null;
        int turn = 0;
        bool finished = false;

        public void SetBoard(int n = 1)
        {
            //n is too small to play but make sure that it is greater than 0 
            n = n < 1 ? 1 : n;
            boardSize = n;
            turn = 0;
            finished = false;
            board = new int[ n * n ];
        }

        public int PlacePiece(int row, int col, int player)
        {
            /*
            for 3 column the indexes are 
            0 1 2
            3 4 5
            6 7 8
            for row 1 column 1 index = (3 * 0) + (0) = 0 
            for row 3 column 3 index = (3 * (3-1)) + (3-1) = 8
            */
            if (!finished)
            {
                int index = (boardSize * (row - 1)) + (col - 1);
                board[index] = player;
                int winner = CheckWinner();
                turn++;
                return Convert.ToInt32(winner);
            }
            else
            {
                return 0;
            }
        }

        private int CheckWinner()
        {
            //the checks will return 0 if no winner, 1 if player 1 wins, 2 if player 2 wins
            //they will also set the finished flag if there is a winner to turn off placing pieces but also makes these checks cleaner.
            int winner;
            winner = CheckHorizontal();
            if(!finished)
            {
                winner = CheckVertical();
            }
            else if (!finished)
            {
                winner = CheckDiagonal();
            }
            else if(!finished && turn == boardSize * boardSize)// if no winner by the last turn set as finished.
            {
                finished = true;
            }
            return winner;
        }

        private int CheckHorizontal()
        {
            try
            {
                int row = boardSize;
                int player = 0;
                while (row != 0)
                {
                    bool horizWin = true;
                    int start = boardSize * (row - 1);//-1 to handle 0 based count
                    int end = (boardSize * row) - 1;//stopping 1 field short from the end so the check 3 rows down won't break on out of scope error
                    for (int i = start; i < end; i++)
                    {
                        player = board[i];
                        if (!(board[i] == 1 || board[i] == 2) || (board[i] != board[i + 1]))//check for 1 or 2 so we don't declare no plays a winner
                        {
                            horizWin = false;
                            break;
                        }
                    }
                    if (horizWin)
                    {
                        finished = true;
                        return player;
                    }
                    row--;
                }
                return 0;
            }catch(Exception ex)
            {
                return 0;
            }
        }

        private int CheckVertical()
        {
            try
            {
                int col = boardSize;
                int player = 0;
                while (col != 0)
                {
                    bool verWin = true;
                    int[] cols = new int[boardSize];
                    /*
                        for 3 column the indexes are 
                        0 1 2
                        3 4 5
                        6 7 8
                        in the for below the first loop i = 3-1 (2)
                        so cols[i] = 3 * 2 + (3 - 1) or 8
                        second loop i = 2 - 1 (1)
                        so cols[i] = 3 * 1 + (3-1) or 5
                        etc
                     */
                    for (int i = boardSize - 1; i >= 0; i--)
                    {
                        cols[i] = boardSize * i + (col - 1);
                    }
                    for (int j = 0; j < cols.Length - 1; j++) // stopping  legth 1 short so the +1 below doesn't break
                    {
                        player = board[j];
                        if ((board[j] == 1 || board[j] == 2) && (board[j] != board[j + 1]))//check for 1 or 2 so we don't declare no plays a winner
                        {
                            verWin = false;
                            break;
                        }
                    }
                    if (verWin)
                    {
                        finished = true;
                        return player;
                    }
                    col--;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private int CheckDiagonal()
        {
            try
            {
                /*
                for 3 column the indexes are 
                0 1 2
                3 4 5
                6 7 8
                top left to bottom right 0,4,8 ((boardSize + 1) * colMin
                bottom left to top right  2,4,6 ((boardSize - 1) * (colMin + 1))
                */
                int col = boardSize;
                int[] diaDown = new int[boardSize];
                int[] diaUp = new int[boardSize];
                while (col != 0)
                {
                    int colMin = col - 1;
                    diaDown[colMin] = (boardSize + 1) * colMin;
                    diaUp[colMin] = (boardSize - 1) * (colMin + 1);
                    col--;
                }
                int winnerUp = RunDiagonal(diaUp);
                int winnerDown = RunDiagonal(diaDown);
                if (winnerUp != 0 && finished)
                {
                    return winnerUp;
                }
                else if (winnerDown != 0 && finished)
                {
                    return winnerDown;
                }
            }catch(Exception ex)
            {
                return 0;
            }
            return 0;
        }

        private int RunDiagonal(int[] indexes)
        {
            try
            {
                bool diaWin = true;
                int player = 0;
                for (int i = 0; i < indexes.Length - 1; i++)
                {
                    player = board[indexes[i]];
                    if ((board[indexes[i]] == 1 || board[indexes[i]] == 2) && (board[indexes[i]] != board[indexes[i] + 1]))//check for 1 or 2 so we don't declare no plays a winner
                    {
                        diaWin = false;
                        break;
                    }
                }
                if (diaWin)
                {
                    finished = true;
                    return player;
                }
            }catch(Exception ex)
            {
                return 0;
            }
            return 0;
        }
    }
}
