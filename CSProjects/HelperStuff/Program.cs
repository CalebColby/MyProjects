namespace HelperStuff
{
    public class Program
    {
        public static void Main()
        {
            int glueCrewCount = 3;

            List<int> myNums = new List<int> { 2, 6, 3, 9, 12};

            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            glueCrewCount = Multiply(glueCrewCount);
        }

        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        private static int Multiply(int num)
        {
            return num * num;
        }
    }
}