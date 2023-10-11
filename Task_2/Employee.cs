using System;

namespace Task_2
{
    public class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;

            switch (position.ToLower())
            {
                case "manager":
                    baseSalary = 30000;
                    break;
                case "developer":
                    baseSalary = 40000;
                    break;
                case "designer":
                    baseSalary = 35000;
                    break;
                default:
                    Console.WriteLine("Invalid position.");
                    return;
            }

            double salary = baseSalary + (experience * 1000);
            double tax = 0.15 * salary;
            
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Tax: " + tax);
        }
    }
}