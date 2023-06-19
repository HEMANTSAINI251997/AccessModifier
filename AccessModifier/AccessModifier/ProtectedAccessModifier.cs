using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class ProtectedAccessModifier
    {
        protected void protectedaccessmodified()
        {
            Console.WriteLine("IT IS A PROTECTED FUNCTION");
        }
        public void info()
        {
            protectedaccessmodified();
        }

    }
}
