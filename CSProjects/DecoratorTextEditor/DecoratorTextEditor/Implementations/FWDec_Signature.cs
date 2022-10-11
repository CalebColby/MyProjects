using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Abstractions;

namespace DecoratorTextEditor.Implementations
{
    public class FWDec_Signature : TEAbst
    {
        public override string EditText(string text)
        {
            //Signature Adding Logic Here
            string signature = "Mike Pitcher, October 5th";

            text = $"{text}\n\n{signature}";

            if (SubItem == null) return text;
            return SubItem.EditText(text);
        }

        public FWDec_Signature(TEAbst subItem = null) : base(subItem)
        {
            
        }
    }
}
