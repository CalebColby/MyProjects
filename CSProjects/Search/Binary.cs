using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Binary
    {
        public static int searchBinary(int[] Items, int target)
        {
            return RBinary(Items, target, 0, Items.Length - 1);
        }

        private static int RBinary(int[] Items, int target, int min, int max)
        {
            if (max <= min)
            {
                if (Items[max] == target)
                {
                    return max;
                }
                else
                {
                    return -1;
                }
            }
            int mid = (max + min) / 2;
            if (Items[mid] == target)
            {
                return mid;
            }
            else if (Items[mid] < target)
            {
                return RBinary(Items, target, mid + 1, max);
            }
            else
            {
                return RBinary(Items, target, min, mid - 1);
            }
        }
    }
}
