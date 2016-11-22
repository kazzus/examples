using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_principles
{

//“S” - SRP(Single responsibility principle)
//“O” - Open closed principle
//“L”- LSP(Liskov substitution principle)
//“I” - ISP(Interface Segregation principle)
//“D” - Dependency inversion principle.

    public class Program
    {
        public static void Main(string[] args)
        {
            const string path = @"c:\SOLID_principles_errors.txt";
            Customer testCust = new Customer();
            String.Format("Adding customer to database, in error case of error, exception will be written to file on {0}", path);
            testCust.Add();
            Console.ReadKey();     
        }
    }
}
