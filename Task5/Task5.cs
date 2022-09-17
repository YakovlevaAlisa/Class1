using System;
using System.Numerics;

namespace Task5
{
    public class Task5
    {
/*
 * Задание 5.1. Запустите функцию `main`, нажав зелёный треугольник слева от её имени. Это действие создаст
 * конфигурацию, которую позже можно отредактировать. В этом задании для ввода данных используются
 * либо параметры командной строки, либо консольный ввод. При запуске через Rider параметры командной строки
 * задаются в окне "Run/Edit configurations..." ("Program arguments:").
 */
        public static void Main(string[] args)
        {
            DemoInput(args);
            ComputeFib(args);
        }

        /*
        * Задание 5.2. Разберите код функции `demoInput`.
        * Функция `demoInput`проверяет количество аргументов командной строки, если есть хотя бы 1 аргумент, то
        * сохраняет их в переменную (name), разделяя ' '; иначе запрашивает имя пользователя с клавиатуры,
        * сохраняет его в переменную (name).
        * Затем приветствует его, печатая строку, состоящую из "Привет ", значения переменной name и символа '!' в конце.
        */
        internal static void DemoInput(string[] args)
        {
            string name;
            if (args.Length > 0)
            {
                name = string.Join(' ', args);
            }
            else
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine()!;
            }

            Console.WriteLine($"Привет, {name}!");
        }

/*
 * Задание 5.3. Напишите программу, которая принимает на вход целое неотрицательное число
 * (либо параметром командной строки, либо с клавиатуры) и печатает число Фибоначчи:
 * https://ru.wikipedia.org/wiki/%D0%A7%D0%B8%D1%81%D0%BB%D0%B0_%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8
 * с соответствующим номером. Мы считаем, что нулевым числом Фибоначчи является число 0, а первым — число 1.
 *
 * Для представления чисел Фибоначчи следует использовать длинные целые:
 * - https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger?view=net-6.0
 */

        internal static BigInteger Fib(int n)
        {
            if (n == 0 || n == 1) return n;

            BigInteger f2 = 1;
            BigInteger f1 = 1;

            for (int i = 2; i < n; i++)
            {
                BigInteger temporary;

                temporary = f2;
                f2 += f1;
                f1 = temporary;
            }

            return f2;
        }

        internal static void ComputeFib(string[] args)
        {
            int number;

            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i], out number)) 
                    Console.WriteLine(Fib(number));
            }

            if (args.Length == 0)
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fib(number));
            }

        }
    }
}