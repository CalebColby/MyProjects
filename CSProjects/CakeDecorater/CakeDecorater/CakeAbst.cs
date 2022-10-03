using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDecorater
{
    public abstract class CakeAbst
    {
        protected ICakeItem SubItem = null;


        //This is my ctor to link other options
        public CakeAbst(ICakeItem subItem)
        {
            this.SubItem = subItem;
        }
    }
}
