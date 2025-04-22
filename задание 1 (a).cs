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
            if (x + 12 == 0)
            {
                throw new DivideByZeroException("Знаменатель равен нулю! Деление невозможно.");
            }

            // Вычисление значения выражения
            double y = Math.Tan(x - 2) / (x + 12) + Math.Pow(Math.Cos(x / 2), 2);

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
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
