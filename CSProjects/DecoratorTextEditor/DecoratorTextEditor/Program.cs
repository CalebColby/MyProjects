using DecoratorTextEditor.Controllers;

namespace DecoratorTextEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new FileReader().Run();


            //Wrapping Decorator 1 in Dec 2 would or new Dec2(new Dec1(null)) would shift the characters first
            //and then add the signature. Doing it the other way round new Dec1(new Dec2(null)) would add the 
            //signature and then shift the characters of the signature and original text
        }
    }
}