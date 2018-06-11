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

            Console.WriteLine("Welcome: " + First_Name + " " + Last_Name);

            Console.WriteLine();
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();


        }
    }
}
