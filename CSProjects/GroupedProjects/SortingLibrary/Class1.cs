namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            int counter = 0;
            while (counter < arr.Length)
            {
                for (int i = 0; i < arr.Length - 1; i++)
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
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void SelectionSort(T[] arr)
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
                T temp = arr[i];
                arr[i] = arr[indexOfLowest];
                arr[indexOfLowest] = temp;
            }
        }

        public static void QuickSort(T[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public static int Partition(T[] arr, int start, int end)
        {
            if (start >= end) { return start; }

            T pivot = arr[start];
            while (true)
            {
                while (arr[start].CompareTo(pivot) < 0)
                {
                    start++;
                }

                while (arr[end].CompareTo(pivot) > 0)
                {
                    end--;
                }

                if (start == end) { return start; }

                T temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
            }
        }

        private static void QuickSort(T[] arr, int start, int end)
        {
            if (start >= end) { return; }
            int pivotIndex = Partition(arr, start, end);
            QuickSort(arr, start, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, end);
        }

        public static void MergeSort(T[] arr)
        {
            if (arr.Length > 1)
            {
                int splitIndex = arr.Length/2;
                T[] arrLeft = arr[..splitIndex];
                T[] arrRight = arr[splitIndex..];
                MergeSort(arrLeft);
                MergeSort(arrRight);
                Merge(arr, arrLeft, arrRight);
            }
            return;
        }

        public static void Merge(T[] arr, T[] arrLeft, T[] arrRight)
        {
            for (int i = 0, j = 0; i + j < arr.Length;)
            {
                if (arrLeft[i].CompareTo(arrRight[j]) < 0)
                {
                    arr[i + j] = arrLeft[i];
                    i++;
                }
                else if (arrLeft[i].CompareTo(arrRight[j]) > 0)
                {
                    arr[i + j] = arrRight[j];
                    j++;
                }
                else
                {
                    arr[i + j] = arrLeft[i];
                    i++;
                    arr[i + j] = arrRight[j];
                    j++;
                }

                if(i == arrLeft.Length)
                {
                    while(j < arrRight.Length)
                    {
                        arr[i + j] = arrRight[j];
                        j++;
                    }
                    break;
                }else if(j == arrRight.Length)
                {
                    while(i < arrLeft.Length)
                    {
                        arr[i + j] = arrLeft[i];
                        i++;
                    }
                    break;
                }
            }
        }
    }
}
