using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_1
{
    public class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;
        private int salary;
        private List<Employee> allEmployees =new List<Employee>();
        public List<Employee> getAllEmployee()
        {
            return allEmployees;
        }

        public void addEmployee(string name, int pay,int salary)
        {
            allEmployees.Add(new Employee(name,pay,salary));
        }

        public Employee() { }
        public Employee(string name,int paymentPerhour, int salary)
        {
            this.name = name;
            this.paymentPerHour = paymentPerhour;
            this.salary = salary;
        }
        public Employee(string name, int paymentPerhour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerhour;

        }
        public string Name
        {
            get { return name; }
            set { name =value; }
        }
        public int PaymentPerHour
        {
            get { return paymentPerHour; }
            set { paymentPerHour = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int calculateSalary(int w, int p)
        {
            return w * p;
        }

        public string getName()
        {
            Console.Write("enter name: ");
            string namef = Console.ReadLine();
            Employee em = allEmployees.Find(e => e.Name.Equals(namef, StringComparison.OrdinalIgnoreCase));
            if ( em!= null)
            {
                return "fond employee "+em.getName();
            }
            else
            {
                return "not found "+namef+" employee!";
            }
        }

        public override string ToString()
        {
            return "name:"+ name + " paymentPerHour:" + paymentPerHour ;
        }


    }
}
