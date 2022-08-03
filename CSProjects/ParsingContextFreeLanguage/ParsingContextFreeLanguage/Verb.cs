using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContextFreeLanguage
{
    public class Verb
    {
        public Verb(string value)
        {
            this.value = value;
        }

        public string value { private set; get; }
    }
}
