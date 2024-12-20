using System;

class Program
{
    static void Main()
    {
        // Вхідне число
        Console.Write("Введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        // Одиничний лямбда-вираз з використанням Predicate
        Predicate<double> isPositive = n => n > 0;

        // Перевірка, чи є число додатним
        if (isPositive(number))
            Console.WriteLine("Число додатне.");
        else
            Console.WriteLine("Число не є додатним.");

        Console.ReadKey();
    }
}
