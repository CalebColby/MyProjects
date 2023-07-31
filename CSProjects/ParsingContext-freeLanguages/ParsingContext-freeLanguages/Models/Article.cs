using ParsingContext_freeLanguages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingContext_freeLanguages.Models
{
    internal class Article : Word
    {
        public Article(string word) : base(word)
        {
        }

        private static string[] validArticles = { "a", "the" };
        public static bool Check(string potintialWord)
        {
            foreach (var member in validArticles)
            {
                if (potintialWord.Trim().ToLower() == member) return true;
            }
            return false;
        }
    }
}
