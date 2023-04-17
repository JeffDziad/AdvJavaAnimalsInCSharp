using AdvJavaAnimalsInCSharp.interfaces;
using AdvJavaAnimalsInCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.entity
{
    public class Cat : Pet, ITalkable
    {
        public int mousesKilled
        {
            get;
            private set;
        }

        public Cat(int mousesKilled, string name) : base(name) 
        {
            this.mousesKilled = mousesKilled;
        }

        public void addMouse()
        {
            this.mousesKilled++;
        }

        public string talk()
        {
            return "Meow";
        }

        public override string ToString() 
        {
            return "Cat: " + "name=" + this.name + " mousesKilled=" + this.mousesKilled;
        }
    }
}
