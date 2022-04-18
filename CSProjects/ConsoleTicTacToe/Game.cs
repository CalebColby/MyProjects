using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTicTacToe
{
    public static class Game
    {
        private static char[][] board = new char[3][];
        private static (string, char)[] Players = new (string, char)[2];
        public static void Run()
        {
            initializeBoard();
            Players[0] = (GetPlayerName(1), 'X');
            Players[1] = (GetPlayerName(2), 'O');
            int currentPlayer = 0;
            while (true)
            {
                TakeTurn(Players[currentPlayer]);

                if (CheckForWin())
                {
                    Console.WriteLine($"Congratulations {Players[currentPlayer].Item1}, You are the Winner");
                    System.Environment.Exit(0);
                }

                if (CheckForCatsGame())
                {
                    Console.WriteLine("Cat's Game. No Winner");
                    System.Environment.Exit(0);
                }

                currentPlayer = currentPlayer == 0 ? 1 : 0;
            }
        }

        private static string GetPlayerName(int playerNum)
        {
            while (true)
            {
                Console.WriteLine($"Player {playerNum}, what is your Name?");
                string? playerName = Console.ReadLine();
                if (!(playerName.Trim() == null || playerName.Trim() == ""))
                {
                    return playerName;
                }
                else
                {
                    Console.WriteLine("That isn't a valid entry, please provide a name.");
                }
            }
        }

        private static void TakeTurn((string, char) Player)
        {
            while (true)
            {
                printBoard();
                string prompt = $"{Player.Item1}, choose a col";
                int col = GetConsoleInt(prompt, 1, 3) -  1;
                prompt = $"{Player.Item1}, choose a row";
                int row = GetConsoleInt(prompt, 1, 3) - 1;
                if(board[row][col] == ' ')
                {
                    board[row][col] = Player.Item2;
                    break;
                }
                else
                {
                    Console.WriteLine("That Square already has a mark, please choose a different one");
                }
            }
        }

        private static int GetConsoleInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    int conInt = int.Parse(Console.ReadLine());
                    if (conInt >= min && conInt <= max)
                    {
                        return conInt;
                    }
                    else
                    {
                        Console.WriteLine($"Enter an Integer between {min} and {max}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"That wasn't a integer, please enter an integer between {min} and {max}");
                }
            }
        }
        private static bool CheckForWin()
        {
            if(board[0][0] == board[1][0] && board[0][0] == board[2][0])
            {
                if(board[0][0] != ' ' && board[1][0] != ' ' && board[2][0] != ' ')
                {
                    return true;
                }
            }
            if(board[0][1] == board[1][1] && board[0][1] == board[2][1])
            {
                if (board[0][1] != ' ' && board[1][1] != ' ' && board[2][1] != ' ')
                {
                    return true;
                }
            }
            if(board[0][2] == board[1][2] && board[0][2] == board[2][2])
            {
                if (board[0][2] != ' ' && board[1][2] != ' ' && board[2][2] != ' ')
                {
                    return true;
                }
            }
            
            if(board[0][0] == board[0][1] && board[0][0] == board[0][2])
            {
                if (board[0][0] != ' ' && board[0][1] != ' ' && board[0][2] != ' ')
                {
                    return true;
                }
            }
            if(board[1][0] == board[1][1] && board[1][0] == board[1][2])
            {
                if (board[1][0] != ' ' && board[1][1] != ' ' && board[1][2] != ' ')
                {
                    return true;
                }
            }
            if(board[2][0] == board[2][1] && board[2][0] == board[2][2])
            {
                if (board[2][0] != ' ' && board[2][1] != ' ' && board[2][2] != ' ')
                {
                    return true;
                }
            }
            
            if(board[0][0] == board[1][1] && board[0][0] == board[2][2])
            {
                if (board[0][0] != ' ' && board[1][1] != ' ' && board[2][2] != ' ')
                {
                    return true;
                }
            }
            if (board[0][2] == board[1][1] && board[0][2] == board[2][0])
            {
                if (board[0][2] != ' ' && board[1][1] != ' ' && board[2][0] != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckForCatsGame()
        {
            for(int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if(board[i][j] == ' ')
                    {
                        return false;
                    }
                }
            } 
            return true;
        }

        

        private static void initializeBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new char[3];
                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = ' ';
                }
            }
        }

        private static void printBoard()
        {
            Console.WriteLine();
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    Console.Write(board[i][j]);
                    if(j != board[i].Length - 1)
                    {
                        Console.Write("| ");
                    }
                }
                if (i != board.Length - 1)
                {
                    Console.Write("\n-------\n");
                }
            }
            Console.WriteLine();
        }
    }
}
