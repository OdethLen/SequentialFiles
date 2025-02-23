using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialFiles
{
    class Person
    {
        public string Name;
        public string Age;
        public string Id;

        public Person ()
        {
            Name = "";
            Age = "";
            Id = "";
        }

        public Person (string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public override string ToString()
        {
            return "Name: " + Name +"Age: " + Age + "Id: " + Id;
        }

    }
}
