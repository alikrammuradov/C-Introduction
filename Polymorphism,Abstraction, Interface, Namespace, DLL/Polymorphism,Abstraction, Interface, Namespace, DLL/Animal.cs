using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    public abstract class Animal
    {
        public string name;

        public abstract void Eat();

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}