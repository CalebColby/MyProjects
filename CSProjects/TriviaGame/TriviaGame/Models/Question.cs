using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Models
{
    public class Question
    {
        public string Quest { get; private set; } = "";


        public Question(string quest)
        {
            Quest = quest;
        }
    }
}
