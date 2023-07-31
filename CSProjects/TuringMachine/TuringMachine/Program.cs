using System.Text;

namespace TuringMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Provide an addition equation in the form of '=x+y' where x and y are positive integers");
                string input = Console.ReadLine();
                var reversedinput = input.Reverse();
                if (validateInput(input))
                {
                    int total = 0;
                    int spaces = 0;
                    foreach (char c in reversedinput)
                    {
                        if (c == '+')
                        {
                            spaces = 0;
                        }
                        else if (c == '=')
                        {
                            Console.WriteLine($"{total}{input}");
                        }
                        else
                        {
                            var current = int.Parse(c.ToString());
                            int place = (int)Math.Pow(10, spaces);
                            total += current * place;
                            spaces++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Given Input ({input}) was invalid");
                }
            }
        }

        private static bool validateInput(string input)
        {
            return true;
        }
    }
}