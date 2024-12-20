using System;

class Program
{
    static void Main()
    {
        // Вхідне число
        Console.Write("Введіть число для обчислення 2*n!: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Блоковий лямбда-вираз для обчислення факторіала
        Func<int, int> factorial = (num) =>
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        };

        // Обчислення 2 * n!
        int fact = factorial(n);
        int result = 2 * fact;

        // Виведення результату
        Console.WriteLine($"2 * {n}! = {result}");
        Console.ReadKey();
    }
}
