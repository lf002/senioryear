using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+ - * /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result;
        bool worked = TryCalc(x, y, op, out result);

        if (worked)
        {
            Console.WriteLine($"Result: {result:F2}");
        }
        else
        {
            Console.WriteLine("Invalid operation or division by zero.");
        }
    }

    static bool TryCalc(double x, double y, char op, out double result)
    {
        result = 0;

        if (op == '+')
        {
            result = x + y;
            return true;
        }
        else if (op == '-')
        {
            result = x - y;
            return true;
        }
        else if (op == '*')
        {
            result = x * y;
            return true;
        }
        else if (op == '/')
        {
            if (y == 0)
            {
                return false;
            }
            result = x / y;
            return true;
        }
        else
        {
            return false;
        }
    }
}