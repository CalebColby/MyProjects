using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class Noun : Word
    {
        public Noun(string word) : base(word)
        {
        }

        private static string[] validNouns = { "cat", "dog", "fish" };
        public static bool Check(string potintialWord)
        {
            foreach (var member in validNouns)
            {
                if (potintialWord.Trim().ToLower() == member) return true;
            }
            return false;
        }
    }
}
