using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContextFreeLanguage
{
    public class Noun
    {
        public Noun(string value)
        {
            this.value = value;
        }

        public string value { private set; get; }

    }
}
