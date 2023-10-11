using System;
using System.Runtime.InteropServices;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter position (manager, developer, designer):");
            string position = Console.ReadLine();

            Console.WriteLine("Enter experience (in years):");
            int experience = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(lastName, firstName);
            employee.CalculateSalary(position, experience);

            
            Console.ReadLine();
        }
    }
}