namespace BigO
{
    public class Program
    {
        public static void Main()
        {

        }

        private static int[] Same(int[] sortedArray1, int [] sortedArray2)
        {
            List<int> SameItems = new List<int> ();

            for (int i = 0; i < sortedArray1.Length; i++) 
            {
                for (int j = 0; j < sortedArray2.Length; j++)
                {
                    if(sortedArray1[i] == sortedArray2[j])
                    {
                        SameItems.Add (sortedArray1[i]);
                        //sortedArray2[j] = ;
                        break;
                    }
                }
            }

            return SameItems.ToArray();
        }
    }
}