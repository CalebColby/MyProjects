using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDecorater
{
    public class Dec_Box : ICakeItem
    {
        public double getCost()
        {
            return 1.75;
        }

        public string getDesc()
        {
            return "Cake Box";
        }
    }
}
