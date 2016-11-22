using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_principles
{
    //SRP(Single responsibility principle)
    public class Customer
    {
        private FileLogger obj = new FileLogger();
        public virtual void Add()
        {
            try
            {
                //Database code goes here;
                
            }
            catch (Exception ex)
            {

                obj.Handle(ex.ToString());
            }
        }
    }
}
