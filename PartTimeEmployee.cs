using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_1
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHour;
        public PartTimeEmployee(string name,int paymentPerhour, int workingHour) : base(name, paymentPerhour)
        {
            this.workingHour = workingHour;
            
        }
        public int calculateSalary(int w,int p)
        {
            return w * p;
        }
        public override string ToString()
        {
            return base.ToString()+ " workingHour:"+ workingHour;
        }
    }
}
