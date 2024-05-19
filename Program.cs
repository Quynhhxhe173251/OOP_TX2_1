using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            int choice;
            int salary;
            do {
                Console.WriteLine("1.add employee");
                Console.WriteLine("2.find emplyee by name");
                Console.WriteLine("3.find employee have hight salary");
                Console.WriteLine("4.exits!");
                Console.Write("enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter your name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("enter paymentPerhour: ");
                        string pay = Console.ReadLine();


                        try
                        {
                            if (int.TryParse(pay, out int num) && !string.IsNullOrWhiteSpace(name))
                            {
                                if (num > 0)
                                {

                                    Console.WriteLine("add success!");
                                    salary = employee.calculateSalary(8, num);
                                    employee.addEmployee(name, num, salary);
                                }
                                else
                                {
                                    Console.WriteLine("number must greater than zero!");
                                }

                            }
                            else
                            {
                                Console.WriteLine("num and name is not null!");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter name: ");
                        string namef = Console.ReadLine();
                        List<Employee> list = employee.getAllEmployee();
                        Employee em = list.Find(e=>e.Name.Equals(namef,StringComparison.OrdinalIgnoreCase));

                        if (em != null)
                        {
                            Console.WriteLine($"found employee :{em.Name}");

                        }
                        else
                        {
                            Console.WriteLine($"not found employee :{namef}");
                        }
                        break;
                    case 3:
                        int maxSala = 0;
                        list = employee.getAllEmployee();
                        string nameE = "";
                        foreach (Employee e in list)
                        {
                            int Sala = e.Salary;
                            string nameEm = e.Name;
                            if (Sala > maxSala)
                            {
                                maxSala = Sala;
                                nameE = e.Name;
                            }
                        }
                        Console.WriteLine($"the salary max is: {maxSala} of {nameE}");
                        break;
                    case 4:
                        Console.WriteLine("exist program...");
                        break;
                    default: 
                        Console.WriteLine("enter choice from 1 to 4"); 
                        break;
                }

            } while (choice !=4);



            foreach (Employee e in employee.getAllEmployee())
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}