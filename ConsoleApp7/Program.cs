using System;

class Program
{
    static void Main()
    {
        // Вхідні дані
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону квадрата: ");
        double side = Convert.ToDouble(Console.ReadLine());

        // Одиничні лямбда-вирази для обчислення площ
        Func<double, double> circleArea = r => Math.PI * r * r;
        Func<double, double> squareArea = s => s * s;

        // Обчислення площ
        double circle = circleArea(radius);
        double square = squareArea(side);

        // Виведення результатів
        Console.WriteLine($"Площа кола: {circle}");
        Console.WriteLine($"Площа квадрата: {square}");

        // Порівняння площ
        if (circle > square)
            Console.WriteLine("Площа кола більша.");
        else if (circle < square)
            Console.WriteLine("Площа квадрата більша.");
        else
            Console.WriteLine("Площі однакові.");

        Console.ReadKey();
    }
}
