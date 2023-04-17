using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.model
{
    public abstract class Pet
    {
        protected string name;

        public Pet(string name) { this.name = name; }

        public string getName() { return name; }
    }
}
