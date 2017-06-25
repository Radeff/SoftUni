using System;

namespace _02.Problem
{
    public class KnightGame
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var board = new char[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                var filler = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = filler[j];
                }
            }

            var minimumHorsesRemoved = 0;

            while (CheckHits(board) > 0)
            {
                minimumHorsesRemoved++;
            }

            Console.WriteLine(minimumHorsesRemoved);
        }

        public static int CheckHits(char[][] board)
        {
            var len = board.Length;
            var bestRow = -1;
            var bestCol = -1;
            var bestHitCounter = 0;
            var deletedHorses = 0;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    var hitCounter = 0;

                    if (board[i][j] == 'K')
                    {
                        //move right
                        if (j + 2 < len)
                        {
                            //move right down
                            if (i + 1 < len)
                            {
                                if (board[i + 1][j + 2] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                            //move right up
                            if (i - 1 >= 0)
                            {
                                if (board[i - 1][j + 2] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                        }
                        //move down
                        if (i + 2 < len)
                        {
                            //down right
                            if (j + 1 < len)
                            {
                                if (board[i + 2][j + 1] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                            //down left
                            if (j - 1 >= 0)
                            {
                                if (board[i + 2][j - 1] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                        }
                        //move left
                        if (j - 2 >= 0)
                        {
                            //move left up
                            if (i - 1 >= 0)
                            {
                                if (board[i - 1][j - 2] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                            //move right up
                            if (i + 1 < len)
                            {
                                if (board[i + 1][j - 2] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                        }
                        //move up
                        if (i - 2 >= 0)
                        {
                            //move up right
                            if (j + 1 < len)
                            {
                                if (board[i - 2][j + 1] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                            //move up left
                            if (j - 1 >= 0)
                            {
                                if (board[i - 2][j - 1] == 'K')
                                {
                                    hitCounter++;
                                }
                            }
                        }

                        if (hitCounter > bestHitCounter)
                        {
                            bestHitCounter = hitCounter;
                            bestRow = i;
                            bestCol = j;
                        }
                    }
                }
            }

            if (bestHitCounter == 0)
            {
                return deletedHorses;
            }

            board[bestRow][bestCol] = '0';
            deletedHorses++;
            return deletedHorses;
        }
    }
}
