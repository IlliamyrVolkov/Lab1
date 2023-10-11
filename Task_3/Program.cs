using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);
            user.DisplayUserInfo();
            
            Console.ReadLine();
        }
    }
}