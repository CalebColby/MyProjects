using System.Collections;
using ParsingContext_freeLanguages.Abstractions;
using ParsingContext_freeLanguages.Models;

namespace ParsingContext_freeLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "Awaiting Input";
            while (true)
            {
                Console.WriteLine(output);
                string input = Console.ReadLine();
                if (IsValidSentence(input, out Sentence sent))
                {
                    output = Respond(sent);
                }
                else
                {
                    output = "I couldn't understand what you wrote, Please write something else";
                }
            }
        }

        private static bool IsValidSentence(string? input, out Sentence sent)
        {
            sent = null;
            if (string.IsNullOrEmpty(input)) return false;

            string[] set = input.Split(' ');
            List<Word> sentence = new List<Word>();
            foreach (var word in set)
            {
                if(Noun.Check(word)) sentence.Add(new Noun(word));
                else if(Verb.Check(word)) sentence.Add(new Verb(word));
                else if(Preposition.Check(word)) sentence.Add(new Preposition(word));
                else if(Article.Check(word)) sentence.Add(new Article(word));
                else return false;
            }

            var iter = sentence.GetEnumerator();

            if (iter.MoveNext())
            {
                NounPhrase np = NounPhrase.Check(ref iter);
                if (np != null)
                {
                    VerbPhrase vp = VerbPhrase.Check(ref iter);
                    if (vp != null)
                    {
                        if (iter.MoveNext()) return false;
                        sent = new Sentence(np, vp);
                        return true;
                    }
                }
            }
            return false;
        }

        private static string Respond(Sentence sent)
        {
            return new Random().Next() % 2 == 1 ? $"Why does {sent.nounPhrase} {sent.verbPhrase.verb}" : $"Where is {sent.nounPhrase} that {sent.verbPhrase}";
        }
    }
}