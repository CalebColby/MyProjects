using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Abstractions;

namespace DecoratorTextEditor.Implementations
{
    public class FWDec_CharUpShifter : TEAbst
    {

        public override string EditText(string text)
        {
            // Character Shifting Logic Here
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (letter >= 'a' && letter <= 'z')// This Checks that the character is a letter and not a number
                {
                    letter = (char)(letter + 1);

                    if (letter > 'z') letter = (char)(letter - 26);
                }
            }

            text = buffer.ToString();

            if(SubItem == null) return text;
            return SubItem.EditText(text);
        }
        public FWDec_CharUpShifter(TEAbst subItem) : base(subItem)
        {
            
        }
    }
}
