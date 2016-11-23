using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_principles
{
    //“O” - Open closed principle
    public class Customer1
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    public class SilverCustomer : Customer1
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }

    public class goldCustomer : Customer1
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
}
