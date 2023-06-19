using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Program:PrivateProtectedAccessModifer //, ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome in access modifier"); 
            PublicAccessModifier obj = new PublicAccessModifier();
            obj.Intro();
            PrivateAccessModifier obj2 = new PrivateAccessModifier();
            obj2.Intro();  
            //ProtectedAccessModifier obj3 = new ProtectedAccessModifier();
            //obj3.info();
            //Program obj4 = new Program();   
            //obj4.info();
            InternalAccessModifier obj5 = new InternalAccessModifier(); 
            obj5.internalaccessmodifier();
            int m = (int) Month.January;
            Month p = Month.January;
            Console.WriteLine(m);
            Console.WriteLine(p);
            Cons obj6 = new Cons("CONSTRUCTER STRING NAME - HEM");
            Cons obj7 = new Cons();
            Program obj8 = new Program();
            Console.WriteLine(obj8.name);
            ProtectedInternalAccessModifer obj9 = new ProtectedInternalAccessModifer(); 
            Console.WriteLine(obj9.name);

        }
    }
}
