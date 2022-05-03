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
            foreach (Isomorph iso in words)
            {
                if (!ExactIsos.ContainsKey(iso.getIsoSign()))
                    ExactIsos.Add(iso.getIsoSign(), new List<Isomorph>());

                ExactIsos[iso.getIsoSign()].Add(iso);
            }

            string output = "Exact Isomorphs\n";

            foreach (var isos in ExactIsos)
            {
                List<Isomorph> isoList = isos.Value;
                if(isoList.Count > 1)
                {
                    output = $"{output}\n{isos.Key}:";
                    foreach(Isomorph iso in isoList)
                    {
                        output = $"{output} {iso.getIsoWord()}";
                    }
                }
            }

            return output + "\n\n";
        }
        
        private static string generateLooseString(List<Isomorph> words)
        {
            Dictionary<string, List<Isomorph>> LooseIsos = new Dictionary<string, List<Isomorph>>();
            foreach (Isomorph iso in words)
            {
                if (!LooseIsos.ContainsKey(iso.getLooseIsoSign()))
                    LooseIsos.Add(iso.getLooseIsoSign(), new List<Isomorph>());

                LooseIsos[iso.getLooseIsoSign()].Add(iso);
            }

            string output = "Loose Isomorphs\n";
            foreach (var isos in LooseIsos)
            {
                List<Isomorph> isoList = isos.Value;
                if (isoList.Count > 1)
                {
                    output = $"{output}\n{isos.Key}:";
                    foreach (Isomorph iso in isoList)
                    {
                        output = $"{output} {iso.getIsoWord()}";
                    }
                }
            }
            return output + "\n\n";
        }
        
        private static string generateNonString(List<Isomorph> words)
        {
            Dictionary<string, List<Isomorph>> LooseIsos = new Dictionary<string, List<Isomorph>>();
            foreach (Isomorph iso in words)
            {
                if (!LooseIsos.ContainsKey(iso.getLooseIsoSign()))
                    LooseIsos.Add(iso.getLooseIsoSign(), new List<Isomorph>());

                LooseIsos[iso.getLooseIsoSign()].Add(iso);
            }
            string output = "Non-Isomorphs\n";
            foreach (var isos in LooseIsos)
            {
                List<Isomorph> isoList = isos.Value;
                if (isoList.Count == 1)
                {
                    foreach (Isomorph iso in isoList)
                    {
                        output = $"{output} {iso.getIsoWord()}";
                    }
                }
            }
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
