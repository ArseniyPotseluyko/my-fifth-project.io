using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ввод значения x с клавиатуры
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // Проверка на деление на ноль в знаменателе
            if (2 * x + 6 == 0)
            {
                throw new DivideByZeroException("Знаменатель равен нулю! Деление невозможно.");
            }

            // Проверка на допустимость значения для логарифма
            if (x <= 0)
            {
                throw new ArgumentOutOfRangeException("Аргумент для натурального логарифма должен быть положительным.");
            }

            // Вычисление значения выражения
            double y = Math.Log(x) - Math.Atan(Math.Pow(x, 3)) / (2 * x + 6);

            // Вывод результата
            Console.WriteLine($"Результат y = {y:F4}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вы вводите корректное число.");
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
