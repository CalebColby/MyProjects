using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDecorater
{
    public class Dec_Sprinkles : CakeAbst, ICakeItem
    {
        public double getCost()
        {
            if (SubItem == null) return 0.50;
            return SubItem.getCost() + 0.50; // Decorater Stuff occurs here
        }

        public string getDesc()
        {
            if (SubItem == null) return "-add Sprinkles";
            return "-add Sprinkles\n" + SubItem.getDesc();
        }

        public Dec_Sprinkles(ICakeItem subItem) : base(subItem)
        {

        }
    }
}
