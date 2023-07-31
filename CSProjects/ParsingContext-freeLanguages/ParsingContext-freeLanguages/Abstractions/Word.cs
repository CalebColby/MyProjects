using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Abstractions
{
    abstract class Word
    {
        public string value { protected set; get; }
        protected Word(string word) { this.value = word; }

        public override string ToString() { return value;}
    }
}
