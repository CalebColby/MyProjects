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
                Console.WriteLine("--------------------------------------------------------------\nPlease Enter Something");
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
            foreach (char let in input)
            {
                switch(state)
                {
                    case 'A':
                        if(let == 'H' || let == 'h')  state = 'B'; 
                        else state = 'Z'; 
                        break;
                    case 'B':
                        if(let == 'i') state = 'C'; 
                        else state = 'Z'; 
                        break;
                    case 'C':
                        if(let == ' ')
                        {
                            state = 'D';
                            return true;
                        }
                        else state = 'Z'; 
                        break;
                    case 'D': // technically unreachable, but listed here for completeness anyway
                        return true;
                    case 'Z':
                        if(let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'C'); //EoS Checker
        }

        private static bool CheckHello(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch (state)
                {
                    case 'A':
                        if (let == 'H' || let == 'h') state = 'B'; 
                        else state = 'Z'; 
                        break;
                    case 'B':
                        if(let == 'e') state = 'C'; 
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'l') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == 'l') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == 'o') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == ' ')
                        {
                            state = 'G';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'G': //technically unreachable, but here for completeness anyway
                        return true;
                    case 'Z':
                        if(let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'F'); //EoS Checker
        }

        private static bool CheckCowboy(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch (state)
                {
                    case 'A':
                        if (let == 'H' || let == 'h') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'o') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'w') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == 'd') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == 'y') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == ' ')
                        {
                            state = 'G';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'G': //technically unreachable, but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'F'); //EoS Checker
        }

        private static bool CheckAloha(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch (state)
                {
                    case 'A':
                        if (let == 'A' || let == 'a') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'l') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'o') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == 'h') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == 'a') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == ' ')
                        {
                            state = 'G';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'G': //technically unreachable, but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'F'); //EoS Checker
        }

        private static bool CheckGratitude(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch(state)
                {
                    case 'A':
                        if (let == 'T' || let == 't') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'h') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'a') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == 'n') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == 'k') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == 's') state = 'G';
                        else if (let == ' ') state = 'H';
                        else state = 'Z';
                        break;
                    case 'G':
                        if(let == ' ')
                        {
                            state = 'L';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'H':
                        if (let == ' ') state = 'H';
                        else if (let == 'Y' || let == 'y') state = 'I';
                        else state = 'Z';
                        break;
                    case 'I':
                        if (let == 'o') state = 'J';
                        else state = 'Z';
                        break;
                    case 'J':
                        if (let == 'u') state = 'K';
                        else state = 'Z';
                        break;
                    case 'K':
                        if (let == ' ')
                        {
                            state = 'L';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'L': //technically unreachable, but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'G' || state == 'K'); //EoS Checker
        }

        private static bool CheckJoey(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch(state)
                {
                    case 'A':
                        if (let == 'H' || let == 'h') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'o') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'w') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == ' ') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == ' ') state = 'E';
                        else if (let == 'a') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == 'r') state = 'G';
                        else state = 'Z';
                        break;
                    case 'G':
                        if (let == 'e') state = 'H';
                        else state = 'Z';
                        break;
                    case 'H':
                        if (let == ' ') state = 'I';
                        else state = 'Z';
                        break;
                    case 'I':
                        if (let == ' ') state = 'I';
                        else if (let == 'y') state = 'J';
                        else state = 'Z';
                        break;
                    case 'J':
                        if (let == 'o') state = 'K';
                        else state = 'Z';
                        break;
                    case 'K':
                        if (let == 'u') state = 'L';
                        else state = 'Z';
                        break;
                    case 'L':
                        if (let == '?') state = 'S';
                        else if (let == ' ') state = 'M';
                        else state = 'Z';
                        break;
                    case 'M':
                        if (let == ' ') state = 'M';
                        else if (let == 'd') state = 'N';
                        else state = 'Z';
                        break;
                    case 'N':
                        if (let == 'o') state = 'O';
                        else state = 'Z';
                        break;
                    case 'O':
                        if (let == 'i') state = 'P';
                        else state = 'Z';
                        break;
                    case 'P':
                        if (let == 'n') state = 'Q';
                        else state = 'Z';
                        break;
                    case 'Q':
                        if (let == 'g') state = 'R';
                        else state = 'Z';
                        break;
                    case 'R':
                        if (let == '?') state = 'S';
                        else state = 'Z';
                        break;
                    case 'S':
                        if (let == 'o')
                        {
                            state = 'T';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'T': //technically unreachable, but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'S'); //EoS Checker
        }

        private static bool CheckHighClass(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch (state)
                {
                    case 'A':
                        if (let == 'H' || let == 'h') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'o') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'w') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == ' ') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == ' ') state = 'E';
                        else if (let == 'd') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == 'o') state = 'G';
                        else state = 'Z';
                        break;
                    case 'G':
                        if (let == ' ') state = 'H';
                        else state = 'Z';
                        break;
                    case 'H':
                        if (let == ' ') state = 'H';
                        else if (let == 'y') state = 'I';
                        else state = 'Z';
                        break;
                    case 'I':
                        if (let == 'o') state = 'J';
                        else state = 'Z';
                        break;
                    case 'J':
                        if (let == 'u') state = 'K';
                        else state = 'Z';
                        break;
                    case 'K':
                        if (let == ' ') state = 'L';
                        else state = 'Z';
                        break;
                    case 'L':
                        if (let == ' ') state = 'L';
                        else if (let == 'd') state = 'M';
                        else state = 'Z';
                        break;
                    case 'M':
                        if (let == 'o') state = 'N';
                        else state = 'Z';
                        break;
                    case 'N':
                        if (let == '?') state = 'O';
                        else state = 'Z';
                        break;
                    case 'O':
                        if (let == ' ') 
                        { 
                            state = 'P'; 
                            return true; 
                        }
                        else state = 'Z';
                        break;
                    case 'P': // technically unreachable but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        else state = 'Z';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'O'); //EoS Checker
        }

        private static bool CheckPirate(string input)
        {
            char state = 'A';
            foreach (char let in input)
            {
                switch(state)
                {
                    case 'A':
                        if (let == 'A' || let == 'a') state = 'B';
                        else state = 'Z';
                        break;
                    case 'B':
                        if (let == 'h') state = 'C';
                        else state = 'Z';
                        break;
                    case 'C':
                        if (let == 'o') state = 'D';
                        else state = 'Z';
                        break;
                    case 'D':
                        if (let == 'y') state = 'E';
                        else state = 'Z';
                        break;
                    case 'E':
                        if (let == ' ') state = 'F';
                        else state = 'Z';
                        break;
                    case 'F':
                        if (let == ' ') state = 'F';
                        else if (let == 'M' || let == 'm') state = 'G';
                        else state = 'Z';
                        break;
                    case 'G':
                        if (let == 'a') state = 'H';
                        else state = 'Z';
                        break;
                    case 'H':
                        if (let == 't') state = 'I';
                        else state = 'Z';
                        break;
                    case 'I':
                        if (let == 'e') state = 'J';
                        else state = 'Z';
                        break;
                    case 'J':
                        if (let == ' ') 
                        { 
                            state = 'K';
                            return true;
                        }
                        else state = 'Z';
                        break;
                    case 'K': // technically unreachable but here for completeness anyway
                        return true;
                    case 'Z':
                        if (let == ' ') state = 'A';
                        break;
                    default:
                        throw new ArgumentException($"Unknown State :{state}, Input was {input}");
                }
                if (state == 'Z' && let == ' ') state = 'A';
            }
            return (state == 'J'); //EoS Checker
        }

        private static void Respond(string[] Responses)
        {
            var randy = new Random();
            Console.WriteLine(Responses[randy.Next(Responses.Length)]);
        }
    }
}