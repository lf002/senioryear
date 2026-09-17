using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the base of the triangle
        Console.Write("Enter the base of the triangle: ");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height of the triangle
        Console.Write("Enter the height of the triangle: ");
        double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = 0.5 * baseOfTriangle * heightOfTriangle;

        // Display the result
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}