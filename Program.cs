using System;

public class DigitSumAndProduct
{
    public static (int sum, int product) CalculateSumAndProduct(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return (sum, product);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть 4-значне число");
        int d = int.Parse(Console.ReadLine());
        (int sum, int product) = DigitSumAndProduct.CalculateSumAndProduct(d);
        Console.WriteLine("Сума цифр: " + sum);
        Console.WriteLine("Добуток цифр: " + product);   
    }
}