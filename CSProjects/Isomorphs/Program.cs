namespace Isomorphs
{
    class Program
    {

        static string rootPath;
        public static void Main()
        {
            string[] items = getIsoStringsFromFile();
            List<Isomorph> words = new List<Isomorph>();
            foreach (string item in items)
            {
                words.Add(new Isomorph(item));
            }
            string output = generateExactString(words) + generateLooseString(words) + generateNonString(words);

            writeToFileAndConsole(output);
            
        }

        private static string generateExactString(List<Isomorph> words)
        {
            Dictionary<string, List<Isomorph>> ExactIsos = new Dictionary<string, List<Isomorph>>();

            string output = "Exact Isomorphs\n\n";

            return output + "\n\n";
        }

        private static string generateLooseString(List<Isomorph> words)
        {
            Dictionary<string, List<Isomorph>> LooseIsos = new Dictionary<string, List<Isomorph>>();

            string output = "Loose Isomorphs\n\n";

            return output + "\n\n";
        }
        
        private static string generateNonString(List<Isomorph> words)
        {
            string output = "Non-Isomorphs\n\n";

            return output;
        }


        private static string[] getIsoStringsFromFile()
        {
            do
            {
                Console.WriteLine("Give me a file path:");
                try
                {
                    string filePath = Console.ReadLine();
                    string[] lines =  System.IO.File.ReadAllLines(filePath);
                    rootPath = filePath.Substring(0, filePath.LastIndexOf("\\"));
                    return lines;
                }
                catch (FileNotFoundException fnfe)
                {
                    Console.WriteLine("Invalid File Path Given.\nCouldn't Find File.\nPlease Give a Valid File Path\n");
                }
            } while (true);
        }

        private static void writeToFileAndConsole(string saveString)
        {
            string filePath = rootPath + "\\output.txt";
            Console.WriteLine(saveString);
            System.IO.File.WriteAllText(filePath, saveString);
        }

    }
}
