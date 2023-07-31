using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class Verb : Word
    {
        public Verb(string word) : base(word)
        {
        }

        private static string[] validVerbs = { "chases" , "bites" };
        public static bool Check(string potintialWord)
        {
            foreach (var member in validVerbs)
            {
                if (potintialWord.Trim().ToLower() == member) return true;
            }
            return false;
        }
    }
}
