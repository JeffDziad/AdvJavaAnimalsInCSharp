using AdvJavaAnimalsInCSharp.interfaces;
using AdvJavaAnimalsInCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.entity
{
    public class Dog : Pet, ITalkable
    {
        public bool friendly
        {
            get;
            private set;
        }

        public Dog(bool friendly, string name) : base(name)
        {
            this.friendly = friendly;
        }

        public string talk() 
        {
            return "Bark";
        }

        public override string ToString() 
        {
            return "Dog: " + "name=" + this.name + " friendly=" + friendly;
        }
    }
}
