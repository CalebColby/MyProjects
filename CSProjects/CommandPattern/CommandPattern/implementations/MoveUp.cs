using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.implementations
{
    public class MoveUp : ICommand
    {
        private Label victim;
        public void Execute(Label victimRef)
        {
            victim = victimRef;

            victim.Top -= 10;
        }

        public void Undo()
        {
            victim.Top += 10;
        }
    }
}
