using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sayıları girin (örnek: 56 45 68 77): ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        int sumOfDifferences = 0;
        int sumOfSquaredDifferences = 0;

        foreach (var number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                int difference = Math.Abs(67 - num);

                if (num < 67)
                {
                    sumOfDifferences += difference;
                }
                else
                {
                    sumOfSquaredDifferences += difference * difference;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş.");
                return;
            }
        }

        Console.WriteLine("Output:");
        Console.WriteLine("Toplam farklar: " + sumOfDifferences);
        Console.WriteLine("Toplam mutlak kare farklar: " + sumOfSquaredDifferences);
    }
}
