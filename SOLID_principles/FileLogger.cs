using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_principles
{
    //SRP(Single responsibility principle)
    public class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\SOLID_principles_errors.txt", error);
        }
    }
}
