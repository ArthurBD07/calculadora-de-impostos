using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua renda: ");
        double renda = double.Parse(Console.ReadLine());
        double taxa;

        if (renda <= 2000.00)
        {
            Console.WriteLine("Isento de impostos!");
        }
        else if (renda <= 3000.00)
        {
            taxa = (renda - 2000) * 0.08;
            Console.WriteLine($"A taxa é R$ {taxa:F2} ");
        }
        else if (renda <= 4500.00)
        {
            taxa = (1000 * 0.08) + ((renda - 3000.00) * 0.18);
            Console.WriteLine($"A taxa é R$ {taxa:F2} ");
        }
        else
        {
            taxa = (1000 * 0.08) + (1500 * 0.18) + ((renda - 4500) * 0.28);
            Console.WriteLine($"A taxa é R$ {taxa:F2} ");
        }
    }

}