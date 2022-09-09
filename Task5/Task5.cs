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
            if (n == 0) return 0;
            if (n == 1) return 1;
            BigInteger f2 = 1, f1 = 1, temp;
            for (int i = 2; i < n; i++)
            {
                temp = f2;
                f2 += f1;
                f1 = temp;
            }
            return f2;
        }

        internal static void ComputeFib(string[] args)
        {
            int len = args.Length, num;
            for (int i = 0; i < len; i++)
            {
                bool test = int.TryParse(args[i], out num);
                if (test) Console.WriteLine(Fib(num));
            }
            if (len == 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fib(num));
            }
        }
    }
}