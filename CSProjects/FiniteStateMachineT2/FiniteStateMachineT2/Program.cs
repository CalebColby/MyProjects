namespace FiniteStateMachineT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0; //Transition Value

            char state = 'B';

            while (state != 'X')
            {
                Console.WriteLine("Input a Phrase (x to quit)");
                while (input != 10)
                {
                    bool wasGreated = false;
                    input = Console.Read();
                    if((char)input == 'x')
                    {
                        state = 'X';
                        input = 10;
                        break;
                    }

                    switch(state)
                    {
                        case 'A':
                            if (input == ' ') state = 'B';
                            break;
                        case 'B':
                            if (input == 'H' || input == 'h') state = 'C';
                            else if (input == ' ') state = 'B';
                            else state = 'A';
                            break;
                        case 'C':
                            if (input == 'I' || input == 'i') state = 'D';
                            else state = 'A';
                            break;
                        case 'D':
                            if (input == ' ' || input == '\r') state = 'E';
                            else state = 'A';
                            break;
                        case 'E':
                            wasGreated = true;
                            break;
                    }
                    Console.WriteLine(wasGreated ? "You said Hi" : "You didn't say Hi");
                }
                state = 'B';
            }
        }
    }
}