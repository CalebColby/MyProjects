using Util;

namespace SolveNQueens
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the NQueens Solver");
            string[] options =
            {
                "Choose a Value for N",
                "Read Explination/Instructions"
            };
            while (true)
            {
                int selection = Util.ConsoleUtility.GetConsoleMenuSelection(options, true);
                switch (selection)
                {
                    case 1:
                        RunNQueensSolver();
                        break;
                    case 2:
                        PrintInscructions();
                        break;
                    case 0:
                        Console.WriteLine("Thank you for using the NQueens Solver");
                        System.Environment.Exit(0);
                        break;
                    default:
                        throw new ArgumentException();
                }; 
            }
        }

        private static void RunNQueensSolver()
        {
            while (true)
            {
                Console.WriteLine("What Value do you want N to have?");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if(n > 0)
                    {
                        new SolveNQueens(n).Go();
                        return;
                    }
                    Console.WriteLine($"The NQueensSolver doesn't work if n is less than 1, Please enter a value that is 1 or greater\nEntered Value: {n}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("The NQueenSolver doesn't work with non numbers, Please enter an Integer Value");
                }
            }
        }

        private static void PrintInscructions()
        {
            Console.WriteLine("The NQueens Solver will find every possilbe solution where N equals the height and length of a chess boeard that houses N Queens and non of said Queens threaten each other under normal chess movement");
        }
    }
}