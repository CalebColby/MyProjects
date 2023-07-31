using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class Preposition : Word
    {
        public Preposition(string word) : base(word)
        {
        }

        private static string[] validPreps = { "with" };
        public static bool Check(string potintialWord)
        {
            foreach (var member in validPreps)
            {
                if (potintialWord.Trim().ToLower() == member) return true;
            }
            return false;
        }

        
        
    }
}
