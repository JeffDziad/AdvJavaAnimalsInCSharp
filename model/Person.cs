using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.model
{
    public abstract class Person
    {
        private string name;

        public Person(string name) { this.name = name; }

        public string getName() { return name; }

        public void setName(string name) { this.name = name; }
    }
}
