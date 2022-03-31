using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isomorphs
{
    internal class Isomorph
    {
        private string isoWord;
        private List<int> isoSign;
        private List<int> looseIsoSign;

        public string getIsoWord() { return this.isoWord; }
        public List<int> getIsoSign() { return this.isoSign; }
        public List<int> getLooseIsoSign() { return this.looseIsoSign; }

        private static List<int> generateIsoSign(string word)
        {
            char[] wordArray = word.ToCharArray();
            List<int> isoSign = new List<int>();
            Dictionary<char, int> isoSignDictionary = new Dictionary<char, int>();
            int dictTracker = 0;
            foreach (char c in wordArray)
            {
                if(!isoSignDictionary.ContainsKey(c))
                {
                    isoSignDictionary.Add(c, dictTracker++);
                }
                isoSign.Add(isoSignDictionary[c]);
            }

            return isoSign;
        }

        private static List<int> generateLooseIsoSign(List<int> isoSign)
        {
            List<int> looseIsoSign = new List<int>();

            return looseIsoSign;
        }

        public void setIsoWord(string isoWord)
        {
            this.isoWord = isoWord ?? throw new ArgumentNullException();
            this.isoSign = generateIsoSign(this.getIsoWord());
            this.looseIsoSign = generateLooseIsoSign(this.getIsoSign()); 
        }
        public Isomorph(string isoWord)
        {
            this.setIsoWord(isoWord);
        }

       
    }
}
