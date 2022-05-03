using AlgoLib;

namespace Starter
{
    public static class Program
    {
        public static void Main()
        {
            var mySLL = new SingleLinkedList<int>();

            mySLL.Add(1);

            Console.WriteLine(mySLL.Count);
        }
    }
}