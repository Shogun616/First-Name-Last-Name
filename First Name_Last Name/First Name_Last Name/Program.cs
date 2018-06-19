using System;

namespace First_Name_Last_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Name ");
            String First_Name = Console.ReadLine();

            Console.Write("Enter Your Last Name ");
            String Last_Name = Console.ReadLine();

            Console.Write("Enter your year of birth: ");
            string years = Console.ReadLine();
            int age = DateTime.Now.Year - int.Parse(years);

            Console.WriteLine("Welcome: " + First_Name + " " + Last_Name + "\nYour current age is: " + age);

            Console.WriteLine();
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();


        }
    }
}
