namespace RegularExpressionStateMachine
{
    internal class Program
    {
        private static string[] AlohaResponses = { "Surf's Up", "Aloha" };
        private static string[] GratitudeResponses = {"You're Welcome", "No, thank you" };
        private static string[] HighResponses = {"Hi", "Sup" };
        private static string[] HelloResponses = {"Hello", "How are you?" };
        private static string[] CowboyResponses = {"Howdy Partner", "Yee Haw!!"};
        private static string[] JoeyResponses = { "(Heavy Brooklyn Accent) How YOU doin'?", "PIVOT" };
        private static string[] HighClassResponses = { "Smashingly!!", "Would you join me for a spot of tea?", "Very well" };
        private static string[] PirateResponses = { "Avast Matey", "Hoist the Sails", "What do you do with a drunken sailor?" };
        private static string[] ElseResponses = {"What great weather!", "Tell me about yourself", "What do you like to do?", "What makes you sad?" };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regular Expression Finite State Machine.");
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Please Say Something");
                string input = Console.ReadLine();
                char state = 'Z';
                foreach (char let in input)
                {
                    switch (state)
                    {
                        case 'A':
                            if (let == 'l') state = 'B';
                            else state = 'Z';
                            break;
                        case 'B':
                            if (let == 'o') state = 'C';
                            else state = 'Z';
                            break;
                        case 'C':
                            if (let == 'h') state = 'D';
                            else state = 'Z';
                            break;
                        case 'D':
                            if (let == 'a') state = 'E';
                            else state = 'Z';
                            break;
                        case 'E':
                            // end case
                            break;
                        case 'F':
                            if (let == 'h') state = 'G';
                            else state = 'Z';
                            break;
                        case 'G':
                            if (let == 'a') state = 'H';
                            else state = 'Z';
                            break;
                        case 'H':
                            if (let == 'n') state = 'I';
                            else state = 'Z';
                            break;
                        case 'I':
                            if (let == 'k') state = 'J';
                            else state = 'Z';
                            break;
                        case 'J':
                            if (let == 's') state = 'K';
                            else if (let == ' ') state = 'L';
                            else state = 'Z';
                            break;
                        case 'K':
                            // end case
                            break;
                        case 'L':
                            if (let == ' ') state = 'L';
                            else if (let == 'y') state = 'M';
                            break;
                        case 'M':
                            if (let == 'o') state = 'N';
                            else state = 'Z';
                            break;
                        case 'N':
                            if (let == 'u') state = 'K';
                            else state = 'Z';
                            break;
                        case 'P':
                            if (let == 'i') state = 'Q';
                            else if (let == 'e') state = 'R';
                            else if (let == 'o') state = 'S';
                            else state = 'Z';
                            break;
                        case 'Q':
                            // end case
                            break;
                        case 'R':
                            if (let == 'l') state = 'T';
                            else state |= 'Z';
                            break;
                        case 'S':
                            if (let == 'w') state = 'W';
                            else state = 'Z';
                            break;
                        case 'T':
                            if (let == 'l') state = 'U';
                            else state = 'Z';
                            break;
                        case 'U':
                            if (let == 'o') state = 'V';
                            break;
                        case 'V':
                            // end case
                            break;
                        case 'W':
                            if (let == 'd') state = 'X';
                            else if (let == ' ') state = 'a';
                            else state = 'Z';
                            break;
                        case 'X':
                            if (let == 'y') state = 'Y';
                            else state = 'Z';
                            break;
                        case 'Y':
                            // end case
                            break;
                        case 'Z':
                            if(let == 'A' || let == 'a') state = 'A';
                            else if (let == 'T' || let == 't') state = 'F';
                            else if (let == 'H' || let == 'h') state = 'P';
                            else state = 'Z';
                            break;
                        case 'a':
                            if (let == 'a') state = 'b';
                            else if (let == 'd') state = 'c';
                            else state = 'Z';
                            break;
                        case 'b':
                            if (let == 'r') state = 'd';
                            break;
                        case 'c':
                            if (let == 'o') state = 'j';
                            else state = 'Z';
                            break;
                        case 'd':
                            if (let == 'e') state = 'e';
                            break;
                        case 'e':
                            if (let == ' ') state = 'f';
                            else state = 'Z';
                            break;
                        case 'f':
                            if (let == 'y') state = 'g';
                            else if (let == ' ') state = 'f';
                            else state = 'Z';
                            break;
                        case 'g':
                            if (let == 'o') state = 'h';
                            else state = 'Z';
                            break;
                        case 'h':
                            if (let == 'u') state = 'i';
                            else state = 'Z';
                            break;
                        case 'i':
                            // end case
                            break;
                        case 'j':
                            if (let == " ")


                            break;
                        default:
                            throw new Exception($"Unexpected State: {state}");
                    }

                    if (state == 'E')
                    {
                        Respond(AlohaResponses);
                    }else if (state == 'K')
                    {
                        Respond(GratitudeResponses);
                    }else if (state == 'Q')
                    {
                        Respond(HighResponses);
                    }else if (state == 'V')
                    {
                        Respond(HelloResponses);
                    }else if (state == 'Y')
                    {
                        Respond(CowboyResponses);
                    }else
                    {
                        Respond(ElseResponses);
                    }
                }
            }
        }

        private static void Respond(string[] Responses)
        {
            var randy = new Random();
            Console.WriteLine(Responses[randy.Next(Responses.Length)]);
        }
    }
}