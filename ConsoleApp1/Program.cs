using System;

class Program
{
    static void Main()
    {
        // Вхідні дані
        Console.Write("Введіть довжину першої сторони: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину третьої сторони: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Одиничний лямбда-вираз з використанням Func
        Func<double, double, double, bool> canFormTriangle = (a, b, c) =>
            a + b > c && a + c > b && b + c > a;

        // Перевірка, чи можуть сторони утворити трикутник
        bool result = canFormTriangle(side1, side2, side3);

        // Виведення результату
        if (result)
            Console.WriteLine("Ці сторони можуть утворити трикутник.");
        else
            Console.WriteLine("Ці сторони не можуть утворити трикутник.");

        Console.ReadKey();
    }
}
