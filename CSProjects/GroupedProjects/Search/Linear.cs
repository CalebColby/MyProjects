using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Linear
    {
        public static int SearchLinear(int[] items, int target)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
