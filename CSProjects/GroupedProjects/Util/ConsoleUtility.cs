using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class ConsoleUtility
    {
        public static int GetConsoleInt(string prompt, int min, int max)
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

        public static float GetConsoleFloat(string prompt, float min, float max)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    float conFloat = float.Parse(Console.ReadLine());
                    if (conFloat >= min && conFloat <= max)
                    {
                        return conFloat;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a value between {min} and {max}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"You didn't enter a number, please enter a number value between {min} and {max}");
                }
                
            }
        }

        public static bool GetConsoleBool(string prompt)
        {
            while (true)
            {
                Console.WriteLine($"{prompt}, Y or N");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Please Enter either 'Y' or 'N'");
                }
                else
                {
                    if(input.Equals("Y") || input.Equals("y"))
                    {
                        return true;
                    }

                    if(input.Equals("N") || input.Equals("n"))
                    {
                        return false;
                    }

                    Console.WriteLine($"'{input}' isn't a valid answer, please enter 'Y' or 'N'");

                }
            }
        }

        public static char GetConsoleChar(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return char.Parse(Console.ReadLine());
                }catch (FormatException)
                {
                    Console.WriteLine("That wasn't a single character, Please enter a single character");
                }
            }
        }

        public static string GetConsoleString(string prompt, bool allowEmpty)
        {
            while (true)
            {
                Console.Write(prompt);
                if (allowEmpty)
                {
                    return Console.ReadLine();
                }
                else
                {
                    string conString = Console.ReadLine();
                    if(conString == null || conString.Trim() == "")
                    {
                        Console.WriteLine($"'{conString}' isn't a valid answer, Please Enter Something");
                    }
                }
            }
        }

        public static int GetConsoleMenuSelection(string[] options, bool allowQuit)
        {
            while (true)
            {
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"\t{i + 1} - {options[i]}");
                }
                if (allowQuit)
                {
                    Console.WriteLine("\t0 - Quit");
                }

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if(input <= options.Length && input >= (allowQuit ? 0 : 1))
                    {
                        return input;
                    }
                }
                catch (FormatException)
                {
                    
                }
                Console.WriteLine($"That wasnt an option, please enter a number between {(allowQuit ? 0 : 1)} and {options.Length} to make your choice.");
            }
        }
    }
}
