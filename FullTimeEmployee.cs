using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_1
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name,int paymentPerhour) : base(name, paymentPerhour)
        {

        }
        public int calculateSalary(int p)
        {
            return 8 * p;
        }
        public override string ToString()
        {
            return base.ToString() ;
        }
    }
}
