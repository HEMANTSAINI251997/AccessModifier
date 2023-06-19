using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PrivateAccessModifier
    {
        private void privateaccessmodifer()
        {
            Console.WriteLine("IT IS A PRIVATE METHOD");
        }
        public void Intro()
        {
            privateaccessmodifer();
        }
    }
}
