using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialFiles
{
    internal class Hero
    {

        public string Name;
        public string Alias;
        public string Gender;
        public string Age;
        public string Quirk;

        public Hero()
        {
            Name = "";
            Alias = "";
            Gender = "";
            Age = "";
            Quirk = "";
        }

        public Hero(string name, string alias, string gender, string age, string quirk)
        { 
            this.Name = name;
            this.Alias = alias;
            this.Gender = gender;
            this.Age = age;
            this.Quirk = quirk;
        }

        public override string ToString() 
        {
            //return Name + Alias + Gender + Age + Quirk;
            return "Name: " + Name + "Alias: " + Alias + "Gender: " + Gender + "Age: " + Age + "Quirk: " + Quirk;
            //return ($"Name: { Name } Alias: {Alias} Gender: {Gender} Age: {Age} Quirk: {Quirk}");
        }
    }
}
