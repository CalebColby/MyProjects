namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            int counter = 0;
            while (counter < arr.Length)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                counter++;
            }
        }

        public static void InsertionSort(T[] arr)
        {

        }

        public static void SelectionSort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int indexOfLowest = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[indexOfLowest].CompareTo(arr[j]) > 0){
                        indexOfLowest = j;
                    }
                }
                T temp = arr[i];
                arr[i] = arr[indexOfLowest];
                arr[indexOfLowest] = temp;
            }
        }
    }
}