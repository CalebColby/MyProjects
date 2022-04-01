using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {
        private string Name { get; set; }

        private int Id { get; set; }

        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
