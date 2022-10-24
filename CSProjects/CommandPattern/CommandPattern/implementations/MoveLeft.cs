using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.implementations
{
    public class MoveLeft : ICommand
    {
        private Label victim;
        public void Execute(Label victimRef)
        {
            victim = victimRef;

            victim.Left -= 10;
        }

        public void Undo()
        {
            victim.Left += 10;
        }
    }
}
