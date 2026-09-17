using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double subtotal = unitPrice * quantity;
        double taxRate = 0.0725;
        double tax = subtotal * taxRate;
        double total = subtotal + tax;

        Console.WriteLine();
        Console.WriteLine($"Item: {itemName}");
        Console.WriteLine($"Unit: ${unitPrice:F2}    Qty: {quantity}");
        Console.WriteLine($"Subtotal: ${subtotal:F2}");
        Console.WriteLine($"Tax (7.25%): ${tax:F2}");
        Console.WriteLine($"Total: ${total:F2}");
    }
}