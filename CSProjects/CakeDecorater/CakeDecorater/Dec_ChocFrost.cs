using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDecorater
{
    public class Dec_ChocFrost : CakeAbst, ICakeItem
    {
        public double getCost()
        {
            if (SubItem == null) return 3.50;
            return SubItem.getCost() + 3.50; // Decorater Stuff occurs here
        }

        public string getDesc()
        {
            if (SubItem == null) return "-add Chocolate Frosting";
            return "-add Chocolate Frosting\n" + SubItem.getDesc();
        }

        public Dec_ChocFrost(ICakeItem subItem) : base(subItem)
        {

        }
    }
}
