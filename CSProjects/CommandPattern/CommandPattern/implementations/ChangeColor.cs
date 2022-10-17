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
            throw new NotImplementedException();

            // get the current color and store it in prevColor so that we can restore it later 
            // during the undo

            // Change the color of the square to the newColor.
        }

        public void Undo()
        {
            throw new NotImplementedException();

            // Change the square's Color back to the value stored in prevColor
        }

        public ChangeColor(Color newColor)
        {
            NewColor = newColor;
        }
    }
}
