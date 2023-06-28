namespace FiniteStateMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wasGreeted = false;
            while (true)
            {
                int response = new Random().Next(3);
                string input = Console.ReadLine();
                if (input == "EXIT") System.Environment.Exit(0);
                if (isHigh(input))
                {
                    RespondToHi();
                    wasGreeted = true;
                }
                else
                {
                    if (wasGreeted)
                    {
                        Respond();
                    }
                    else
                    {
                        RespondToNotGreeted();
                    }
                }
            }
        }

        private static bool isHigh(string input)
        {
            char state = 'A'; //Q0

            foreach (char c in input)
            {
                switch (state)
                {
                    case 'Z':
                        state = (c == ' ') ? 'A' : 'Z';
                        break;
                    case 'A':
                        state = (c == 'h' || c == 'H') ? 'B' : 'Z';
                        if (c == ' ') state = 'A';
                        break;
                    case 'B':
                        state = (c == 'i' || c == 'I') ? 'C' : 'Z';
                        if (c == ' ') state = 'A';
                        break;
                    case 'C':
                        state = (c == ' ') ? 'D' : 'Z';
                        break;
                    case 'D':
                        return true;
                    default:
                        throw new Exception($"Unexpected State: {state}");
                }
            }
            return state == 'C' || state == 'D';
        }

        private static void RespondToHi()
        {
            string[] responses = { "You said Hi", "Hello, My Friend", "Hiya!" };
            Console.WriteLine(responses[new Random().Next(responses.Length)]);
        }

        private static void Respond()
        {
            Console.WriteLine("You didn't say hi");
        }

        private static void RespondToNotGreeted()
        {
            Console.WriteLine("You haven't greeted me");
        }
    }
}