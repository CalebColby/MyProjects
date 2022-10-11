using DecoratorTextEditor.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorTextEditor.Implementations;

namespace DecoratorTextEditor.Controllers
{
    public class FileReader
    {
        private TEAbst FirstDecorator = null;
        public void Run()
        {
            StreamReader sr = new StreamReader
            ("C:\\Users\\Ccolby\\OneDrive - Neumont College of Computer Science\\Documents\\My Projects\\Github"+
             "\\CSProjects\\DecoratorTextEditor\\DecoratorTextEditor\\Output Files\\DecOutput.txt");
            try
            {
                string text = sr.ReadToEnd();

                FirstDecorator = new FRDec_CharDownShifter(new FRDec_CharDownShifter(new FRDec_LineEndingConverter()));
                text = FirstDecorator.EditText(text);
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
