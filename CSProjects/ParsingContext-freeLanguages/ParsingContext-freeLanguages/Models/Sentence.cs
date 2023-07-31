using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class Sentence
    {
        public NounPhrase nounPhrase { private set; get; }
        public VerbPhrase verbPhrase { private set; get; }

        public Sentence(NounPhrase np, VerbPhrase vp)
        {
            this.nounPhrase = np;
            this.verbPhrase = vp;
        }

        public override string ToString()
        {
            return $"{nounPhrase} {verbPhrase}";
        }

    }
}
