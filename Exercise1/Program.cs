using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 40;
            person.Name = "Amar";
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");
            Console.WriteLine($"Person details (After incrementing age) - Name = Amar, Age = {person.Age + 1}");
        }
    }
}