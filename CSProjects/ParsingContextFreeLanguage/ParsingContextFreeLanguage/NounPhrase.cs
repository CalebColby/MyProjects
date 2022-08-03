using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContextFreeLanguage
{
    public class NounPhrase
    {
        public Noun noun { get; set; }

        public Proposition? prop { get; set; }

        public NounPhrase? NP { get; set; }

        public NounPhrase(Noun noun, Proposition? prop = null, NounPhrase? NP = null)
        {
            this.noun = noun;
            this.prop = prop;
            this.NP = NP;
        }
    }
}
