namespace Starter
{
    public static class Program
    {
        public static void Main()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] output = CodeWars.CodeWarsMethods.FoldArray(input, 2);
            foreach (var item in output)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
