namespace ParsingContextFreeLanguage
{
    public class Program
    {

        private static string[] Nouns = {"dog", "cat", "fish" };
        private static string[] Verbs = {"bites", "chases" };
        private static string[] Articles = {"the", "a" };
        private static string[] Prepositions = {"with" };

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do what to say? (Don't include Punctuation!!)");
                string input = Console.ReadLine();
                var inputs = input.Split(" ");
                foreach (var word in inputs)
                {
                    
                }
            }
        }
    }
}