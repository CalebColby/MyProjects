using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContextFreeLanguage
{
    public class Proposition
    {
        public string value { get; set; }

        public Proposition(string value)
        {
            this.value = value;
        }
    }
}
