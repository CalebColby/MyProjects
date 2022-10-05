using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTextEditor.Abstractions
{
    public abstract class TEAbst
    {
        protected TEAbst? SubItem = null;

        public abstract string EditText(string text);

        public void AddDecorator(TEAbst newDec) // This is so that new Decorators can be added to an existing Chain
        {
            if (SubItem == null)
            {
                SubItem = newDec;
            }
            else
            {
                SubItem.AddDecorator(newDec);
            }
        }

        public TEAbst(TEAbst subItem)
        {
            this.AddDecorator(subItem);
        }
    }
}
