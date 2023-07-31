using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class NounPhrase
    {
        public Article article { private set; get; }
        public Noun noun { private set; get; }
        public Preposition? preposition { private set; get; }
        public NounPhrase? nounPhrase { private set; get; }

        public NounPhrase(Article article, Noun noun) 
        {
            this.article = article;
            this.noun = noun;
            this.preposition = null;
            this.nounPhrase = null;
        }

        public NounPhrase(Article article, Noun noun, Preposition preposition, NounPhrase nounPhrase)
        {
            this.article = article;
            this.noun = noun;
            this.preposition = preposition;
            this.nounPhrase = nounPhrase;
        }

        internal static NounPhrase Check(ref List<Word>.Enumerator iter)
        {
            if(iter.Current.GetType() == typeof(Article))
            {
                Article article = (Article)iter.Current;
                if (iter.MoveNext())
                {
                    if(iter.Current.GetType() == typeof(Noun))
                    {
                        Noun noun = (Noun)iter.Current;
                        if (iter.MoveNext())
                        {
                            if(iter.Current.GetType() == typeof(Preposition))
                            {
                                Preposition preposition = (Preposition)iter.Current;
                                if (iter.MoveNext())
                                {
                                    NounPhrase np = NounPhrase.Check(ref iter);
                                    if(np != null)
                                    {
                                        return new NounPhrase(article, noun, preposition, np);
                                    }
                                    return null;
                                }
                                else return null;
                            }
                        }
                        return new NounPhrase(article, noun);
                    }
                }
            }
            return null;
        }

        public override string ToString()
        {
            return preposition == null ? $"{article} {noun}" : $"{article} {noun} {preposition} {nounPhrase}";
        }
    }
}
