using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDecorater
{
    public class Dec_Chocolate : CakeAbst, ICakeItem
    {
        public double getCost()
        {
            if (SubItem == null) return 2.50;
            return SubItem.getCost() + 2.50; // Decorater Stuff occurs here
        }

        public string getDesc()
        {
            if (SubItem == null) return "-add Chocolate";
            return "-add Chocolate\n" + SubItem.getDesc();
        }

        public Dec_Chocolate(ICakeItem subItem) : base(subItem)
        {

        }
    }
}
