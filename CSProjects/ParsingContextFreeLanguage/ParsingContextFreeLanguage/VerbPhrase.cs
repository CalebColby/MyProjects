using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContextFreeLanguage
{
    public class VerbPhrase
    {
        public Verb verb { get; set; }

        public NounPhrase NP { get; set; }

        public VerbPhrase(Verb verb, NounPhrase NP)
        {
            this.verb = verb;
            this.NP = NP;
        }
    }
}
