using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class VerbPhrase
    {
        public Verb verb { private set; get; }
        public NounPhrase? NounPhrase { private set; get; }

        public VerbPhrase(Verb verb, NounPhrase? nounPhrase = null)
        {
            this.verb = verb;
            this.NounPhrase = nounPhrase;
        }

        internal static VerbPhrase Check(ref List<Word>.Enumerator iter)
        {
            if (iter.Current == null) return null;
            if(iter.Current.GetType() == typeof(Verb))
            {
                Verb verb = (Verb)iter.Current;
                if(iter.MoveNext())
                {
                    NounPhrase np = NounPhrase.Check(ref iter);
                    if (np != null)
                    {
                        return new VerbPhrase(verb, np);
                    }
                    return null;
                }
                return new VerbPhrase(verb);
            }
            return null; ;
        }

        public override string ToString()
        {
            return NounPhrase == null ? verb.ToString() : $"{verb} {NounPhrase}";
        }
    }
}
