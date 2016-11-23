using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_principles
{
    //“O” - Open closed principle
    public class Customer1
    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(int TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }
}
