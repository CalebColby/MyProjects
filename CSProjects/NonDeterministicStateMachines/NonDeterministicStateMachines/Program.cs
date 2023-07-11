using System.Collections.Specialized;

namespace NonDeterministicStateMachines
{
    internal class Program
    {
        private static string[] HighResponses = { "Hi", "Sup" };
        private static string[] HelloResponses = { "Hello", "How are you?" };
        private static string[] CowboyResponses = { "Howdy Partner", "Yee Haw!!" };
        private static string[] AlohaResponses = { "Surf's Up", "Aloha" };
        private static string[] GratitudeResponses = { "You're Welcome", "No, thank you" };
        private static string[] JoeyResponses = { "(Heavy Brooklyn Accent) How YOU doin'?", "PIVOT" };
        private static string[] HighClassResponses = { "Smashingly!!", "Would you join me for a spot of tea?", "Very well" };
        private static string[] PirateResponses = { "Avast Matey", "Hoist the Sails", "What do you do with a drunken sailor?" };
        private static string[] ElseResponses = { "What great weather!", "Tell me about yourself", "What do you like to do?", "What makes you sad?" };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Non-Deterministic Finite State Machine");
            while(true)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Please Enter Something");
                Console.WriteLine("--------------------------------------------------------------");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    if (CheckHigh(input)) Respond(HighResponses);
                    else if (CheckHello(input)) Respond(HelloResponses);
                    else if (CheckCowboy(input)) Respond(CowboyResponses);
                    else if (CheckAloha(input)) Respond(AlohaResponses);
                    else if (CheckGratitude(input)) Respond(GratitudeResponses);
                    else if (CheckJoey(input)) Respond(JoeyResponses);
                    else if (CheckHighClass(input)) Respond(HighClassResponses);
                    else if (CheckPirate(input)) Respond(PirateResponses);
                    else Respond(ElseResponses);
                }
            }
        }

        private static bool CheckHigh(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckHello(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch (state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckCowboy(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckAloha(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckGratitude(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckJoey(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckHighClass(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckPirate(string input)
        {
            char state = 'A';
            foreach (char c in input)
            {
                switch(state)
                {
                    case 'A':
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
            }
            throw new NotImplementedException();
        }

        private static void Respond(string[] Responses)
        {
            var randy = new Random();
            Console.WriteLine(Responses[randy.Next(Responses.Length)]);
        }
    }
}