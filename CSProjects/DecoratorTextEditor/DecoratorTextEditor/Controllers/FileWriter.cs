using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Abstractions;
using DecoratorTextEditor.Implementations;

namespace DecoratorTextEditor.Controllers
{
    public class FileWriter
    {

        private TEAbst FirstDecorator = null;
        public void Run()
        {
            Console.WriteLine("Please enter a word or phrase");
            string inputText = "";
            while (true) // using a break statement later saves me having to track a boolean value
            {
                inputText = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputText)) break; // Validating the input
                Console.WriteLine("An Empty string isn't a valid entry");
            }

            FirstDecorator = new FWDec_Signature(new FWDec_CharUpShifter(null));
            FirstDecorator.AddDecorator(new FWDec_CharUpShifter(null));

            Console.WriteLine(FirstDecorator.EditText(inputText));
        }
    }
}
