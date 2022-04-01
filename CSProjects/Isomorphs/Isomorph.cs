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
        public string getIsoSign()
        {
            string output = "";

            foreach (int i in isoSign)
            {
                output = output + i.ToString() + " ";
            }

            return output.Trim();
        }
        
        public string getLooseIsoSign()
        {
            string output = "";

            foreach (int i in looseIsoSign)
            {
                output = output + i.ToString() + " ";
            }

            return output.Trim();
        }
        
        
        public bool compareIsoSign(List<int> other)
        {
            if (other == null) return false;
            if(isoSign.Count != other.Count) { return false; }
            for (int i = 0; i < isoSign.Count; i++) 
                    if (isoSign[i] != other[i]) return false; 
            return true;
        }

        public bool compareLooseIsoSign(List<int> other)
        {
            if (other == null) return false;
            if (looseIsoSign.Count != other.Count) { return false; }
            for (int i = 0; i < looseIsoSign.Count; i++)
                if (looseIsoSign[i] != other[i]) return false;
            return true;
        }

        public void setIsoWord(string isoWord)
        {
            this.isoWord = isoWord ?? throw new ArgumentNullException();
            this.isoSign = generateIsoSign(this.getIsoWord());
            this.looseIsoSign = generateLooseIsoSign(this.isoSign); 
        }
        public Isomorph(string isoWord)
        {
            this.setIsoWord(isoWord);
        }



        private static List<int> generateIsoSign(string word)
        {
            char[] wordArray = word.ToCharArray();
            List<int> isoSign = new List<int>();
            Dictionary<char, int> isoSignDictionary = new Dictionary<char, int>();
            int dictTracker = 0;
            foreach (char c in wordArray)
            {
                if (!isoSignDictionary.ContainsKey(c))
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

            foreach (int i in isoSign)
            {
                if (looseIsoSign.Count() <= i)
                {
                    looseIsoSign.Add(1);
                }
                looseIsoSign[i]++;
            }
            looseIsoSign = looseIsoSign.OrderBy(i => i).ToList();


            return looseIsoSign;
        }
    }
}
