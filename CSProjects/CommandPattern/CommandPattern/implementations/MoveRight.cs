using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.implementations
{
    public class MoveRight : ICommand
    {
        private Label Victim;

        public void Execute(Label victimRef)
        {
            Victim = victimRef;

            Victim.Left += 10;
        }

        public void Undo()
        {
            Victim.Left -= 10;
        }
    }
}
