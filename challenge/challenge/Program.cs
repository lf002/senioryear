using System;

namespace Week_3_1_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }

        static void GetUserAge()
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            try
            {
                int age = int.Parse(ageInput);

                if (age < 0)
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                    GetUserAge();
                }
                else
                {
                    Console.WriteLine($"You are {age} years old.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
                GetUserAge();
            }
        }
    }
}