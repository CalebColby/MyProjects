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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + 1);
                // if (letter > 'z') letter = (char)(letter - 26); // Artifact from a previous iteration
                sb.Append(letter);
            }

            //text = buffer.ToString(); // toString() isn't actually implemented for char arrays so this didn't work
            text = sb.ToString();

            if(SubItem == null) return text;
            return SubItem.EditText(text);
        }
        public FWDec_CharUpShifter(TEAbst subItem = null) : base(subItem)
        {
            
        }
    }
}
