namespace MazeSolver
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Maze Solver Algorithim");
            Console.WriteLine("Please Provide a File Path");
            string filePath = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            List<string[]> SGraphs = new List<string[]>();
            while (lines.Contains(""))
            {
                int index = Array.IndexOf(lines, "");
                SGraphs.Add(lines[0..index]);
                lines = lines[(index+1)..lines.Length];
            }

            foreach (string[] sg in SGraphs)
            {
                Graph g = new Graph(sg);
                Console.WriteLine(g.Solve);
            }
        }
    }
}