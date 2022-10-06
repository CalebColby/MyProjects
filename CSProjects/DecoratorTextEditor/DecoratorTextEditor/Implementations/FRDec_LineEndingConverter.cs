using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Abstractions;

namespace DecoratorTextEditor.Implementations
{
    public class FRDec_LineEndingConverter : TEAbst
    {
        public override string EditText(string text)
        {
            //Signature Removing Logic Here
            text = text.Replace("\n\nMike Pitcher, October 5th", "");

            if (SubItem == null) return text;
            return SubItem.EditText(text);
        }
        public FRDec_LineEndingConverter(TEAbst subItem) : base(subItem)
        {
            
        }
    }
}
