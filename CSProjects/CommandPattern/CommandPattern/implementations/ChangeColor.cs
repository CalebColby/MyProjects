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
        private Color PrevColor;
        private Color NewColor;
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public ChangeColor(Color newColor)
        {
            NewColor = newColor;
        }
    }
}
