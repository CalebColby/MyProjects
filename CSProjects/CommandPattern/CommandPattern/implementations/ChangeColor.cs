using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.implementations
{
    public class ChangeColor : ICommand
    {
        private Label victim;
        private Color PrevColor;
        private Color NewColor;
        public void Execute(Label victimRef)
        {
            victim = victimRef;
            Random randy = new Random();
            NewColor = Color.FromArgb( randy.Next(256), randy.Next(256), randy.Next(256) );
            // get the current color and store it in prevColor so that we can restore it later 
            // during the undo
            PrevColor = victim.ForeColor;
            // Change the color of the square to the newColor.
            victim.ForeColor = NewColor;
        }

        public void Undo()
        {
            victim.ForeColor = PrevColor;

            // Change the square's Color back to the value stored in prevColor
        }
    }
}
