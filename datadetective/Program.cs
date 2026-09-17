using System;

class Program
{
    static void Main()
    {
        int age;
        double gpa;
        bool enrolled;

        Console.Write("Enter age: ");
        string ageInput = Console.ReadLine();
        bool ageWorked = int.TryParse(ageInput, out age);

        if (!ageWorked)
        {
            Console.WriteLine("That didn't work. Please enter a whole number for age.");
            Console.Write("Enter age: ");
            ageInput = Console.ReadLine();
            int.TryParse(ageInput, out age);
        }

        Console.Write("Enter GPA: ");
        string gpaInput = Console.ReadLine();
        bool gpaWorked = double.TryParse(gpaInput, out gpa);

        if (!gpaWorked)
        {
            Console.WriteLine("That didn't work. Please enter a number like 3.25 for GPA.");
            Console.Write("Enter GPA: ");
            gpaInput = Console.ReadLine();
            double.TryParse(gpaInput, out gpa);
        }

        Console.Write("Enter enrollment status (true/false): ");
        string enrolledInput = Console.ReadLine();
        bool enrolledWorked = bool.TryParse(enrolledInput, out enrolled);

        if (!enrolledWorked)
        {
            Console.WriteLine("That didn't work. Please enter true or false.");
            Console.Write("Enter enrollment status (true/false): ");
            enrolledInput = Console.ReadLine();
            bool.TryParse(enrolledInput, out enrolled);
        }

        Console.WriteLine($"Student(age: {age}, gpa: {gpa}, enrolled: {enrolled})");
    }
}