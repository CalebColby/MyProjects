using System.Diagnostics;
using System.Text;

namespace BigO
{
    public class Program
    {
        public static void Main()
        {
            /*int count = 500000/2;

            int[] arr1 = generateRandomArray(count, false);
            int[] arr2 = generateRandomArray(count, false);
            
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int[] arr3 = Same(arr1, arr2);
            sw.Stop();

            //Console.WriteLine($"Time Elapsed: {sw.ElapsedTicks} Ticks\n" +
            //    $"First Array: {ArrayToString(arr1)}\nSecond Array: {ArrayToString(arr2)}\nSorted Array: {ArrayToString(arr3)}");
            Console.WriteLine($"Time Elapsed: {sw.ElapsedTicks} Ticks"); */
        }

        private static bool isPalndrome(string str)
        {
            List<char> chars = new List<char>();
            chars.AddRange(str.ToCharArray());
            while(chars.Contains(' ')) { chars.Remove(' '); }

            List<char> ReversedChars = chars;
            ReversedChars.Reverse();

            return chars == ReversedChars;
        }

        private static int[] Same(int[] arr1, int [] arr2)
        {
            int comparisons = 0;
            int operations = 0;
            List<int> SameItems = new List<int> ();

            List<int> list1 = new List<int>();

            list1.AddRange (arr1);

            for (int i = 0; i < arr2.Length; i++)
            {
                comparisons++;
                if (list1.Contains(arr2[i]))
                {
                    SameItems.Add (arr2[i]);
                    list1.Remove(arr2[i]);
                    operations++;
                    operations++;
                }
            }

            Console.WriteLine($"Comparisons: {comparisons}\nOperations: {operations}");
            return SameItems.ToArray();
        }

        private static int[] generateRandomArray(int length, bool sorted)
        {
            Random rand = new Random();

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next (0, 99);
            }

            if (sorted)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int indexOfLowest = i;
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[indexOfLowest].CompareTo(arr[j]) > 0)
                        {
                            indexOfLowest = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[indexOfLowest];
                    arr[indexOfLowest] = temp;
                }
            }

            return arr;
        }

        private static string ArrayToString(int[] arr)
        {
            StringBuilder sb = new StringBuilder(arr[0].ToString());
            for(int i = 1; i < arr.Length; i++)
            {
                sb.Append($", {arr[i]}");
            }

            return sb.ToString();
        }
    }
}