namespace Isomorphs
{
    class Program
    {
        public static void Main()
        {
            string[] items = getIsoStringsFromFile();
        }


        private static string[] getIsoStringsFromFile()
        {
            do
            {
                Console.WriteLine("Give me a file path:");
                try
                {
                    string filePath = Console.ReadLine();
                    return System.IO.File.ReadAllLines(filePath);
                }
                catch (FileNotFoundException fnfe)
                {
                    Console.WriteLine("Invalid File Path Given.\nCouldn't Find File.\nPlease Give a Valid File Path\n");
                }
            } while (true);
        }

        private static void writeToFileAndConsole()
        {
            
        }

    }
}
