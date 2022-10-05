using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Abstractions;

namespace DecoratorTextEditor.Implementations
{
    public class FRDec_CharDownShifter : TEAbst
    {
        public override string EditText(string text)
        {
            // Character Shifting Logic Here


            if (SubItem == null) return text;
            return SubItem.EditText(text);
        }
        public FRDec_CharDownShifter(TEAbst subItem) : base(subItem)
        {
            
        }
    }
}
