using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PublicAccessModifier
    {
        public void Intro()
        {
            Console.WriteLine("IT IS A PUBLIC METHOD");
            PrivateAccessModifier demo = new PrivateAccessModifier();   
            demo.Intro();
     
         
        }

    }
}
