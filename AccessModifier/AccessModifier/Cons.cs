using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Cons
    {
        public Cons()
        {
            Console.WriteLine("Default Constructor");
        }
        public Cons(string name)
        {
            Console.WriteLine(name);
        }
    }
}
