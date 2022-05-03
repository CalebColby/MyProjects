class Program
{
    static void Main(string[] args)
    {
        int[] items = { 1, 2, 3, 7, 8, 34, 45, 61, 67, 83, 92, 102, 123 }; 

        int target = 34;

       // int index = Search.Linear.SearchLinear(items, target);

        int index = Search.Binary.searchBinary(items, target);

        if(index != -1)
        {
            Console.WriteLine(target + " was found at index: "+index);
            Console.WriteLine("Item at index is: " + items[index]);
        } else
        {
            Console.WriteLine(target + " was not found in the array");
        }
    }
}
