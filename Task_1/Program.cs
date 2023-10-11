using System;

namespace Task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "01103";
            address.Country = "Ukrain";
            address.City = "Kyiv";
            address.Street = "Mikhail Boychuk";
            address.House = "35";
            address.Apartment = "456";

            address.DisplayAddress();

            Console.ReadLine();
        }
    }
}