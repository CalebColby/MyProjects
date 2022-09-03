namespace MadForInputs.Models
{
    public class MadLibViewModel
    {
        public string ProperNoun;
        public string Noun;
        public string Adjective;
        public string Verb;
        public string Adverb;

        public MadLibViewModel(string properNoun, string noun, string adjective, string verb, string adverb)
        {
            ProperNoun = properNoun;
            Noun = noun;
            Adjective = adjective;
            Verb = verb;
            Adverb = adverb;
        }
    }
}
