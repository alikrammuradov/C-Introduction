using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog eating");
        }
        public override void Sound()
        {
            Console.WriteLine("Hav hav");
        }
    }
}
