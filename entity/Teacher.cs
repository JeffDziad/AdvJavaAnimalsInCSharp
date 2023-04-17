using AdvJavaAnimalsInCSharp.interfaces;
using AdvJavaAnimalsInCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.entity
{
    public class Teacher : Person, ITalkable
    {
        public int age
        {
            get;
            set;
        }

        public Teacher(int age, string name) : base(name)
        {
            this.age = age;
        }

        public string talk()
        {
            return "Don't forget to do the assgined reading!";
        }
    }
}
