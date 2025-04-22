using System;

class Program
{
    // Метод PowerA234 для вычисления степеней числа
    static void PowerA234(double A, out double B, out double C, out double D)
    {
        if (A == 0)
        {
            throw new DivideByZeroException("Число A не может быть равно нулю, так как деление на ноль недопустимо.");
        }
        if (A < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(A), "Число A должно быть положительным.");
        }

        B = Math.Pow(A, 2); // Вторая степень
        C = Math.Pow(A, 3); // Третья степень
        D = Math.Pow(A, 4); // Четвертая степень
    }

    static void Main(string[] args)
    {
        try
        {
            // Ввод пяти чисел с клавиатуры
            double[] numbers = new double[5];
            Console.WriteLine("Введите 5 чисел для вычисления их степеней:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nРезультаты вычисления:");
            Console.WriteLine("Число | Вторая степень | Третья степень | Четвертая степень");
            Console.WriteLine("------------------------------------------------------------");

            foreach (double number in numbers)
            {
                PowerA234(number, out double B, out double C, out double D);
                Console.WriteLine($"{number,6:F2} | {B,14:F2} | {C,14:F2} | {D,14:F2}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вы вводите корректные числа.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
