namespace HelloWorld
{
    public class Student
    {
        public string Name { get; private set; }
        
        public static void Greet(string name)
        {
            Student s = new Student();
            Console.WriteLine($"Hello {name}");
        }

    }
}
