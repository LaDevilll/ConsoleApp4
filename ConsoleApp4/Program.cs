﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        //        1. перенести пару заданий из тех что делали до этого, из Main'а в отдельные методы, немного навести порядок, и запомнить синтаксис методов (на след. паре будем усложнять)
        //2. еще задачку на if: написать проверки для склонения слова "рублей" в зависимости от введенного значения.допустим, вводишь 25, выводится "25 рублей", вводишь 2, выводится "2 рубля" и т.д.подумать какие м.б.варианты, и реализовать.
        //3. написать программу, которая проверяет, является ли трехзначное число палиндромом (читается одинаково слева направо и справа налево).
        //4. и из задачника по for'ам: 5, 6, 7
        //5. Вывести числа от 1 до 50, кратные 3. т.е.в цикле for перебираете все числа от 1 до 50, и там же в цикле проверяете делится ли оно на 3 - для этого можно сравнить остаток от деления на 3 с нулем.
        //6. с использованием цикла for вычислить факториал введенного числа. Факториал - это произведение всех целых чисел от 1 до введенного числа, т.е.если ввели 6, то результатом будет 1 * 2 * 3 * 4 * 5 * 6


        //2. еще задачку на if: написать проверки для склонения слова "рублей" в зависимости от введенного значения.допустим, вводишь 25, выводится "25 рублей", вводишь 2,
        //выводится "2 рубля" и т.д.подумать какие м.б.варианты, и реализовать.
        static void M1()
        {
            int a;
            Console.WriteLine("Введите количество рублей");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            if (a < 0)
            {
                Console.WriteLine("Денежная валюта не может быть отрицательной (пока что)");
            }
            else
            {              
                if (a % 10 == 1 && a % 100 != 11)
                    {
                    Console.WriteLine($"{a} рубль");
                }
                else if ((a % 10 >= 2 && a % 10 <= 4) && (a % 100 < 10 || a % 100 >= 20))
                {
                    Console.WriteLine($"{a} рубля");
                }
                else {
                    Console.WriteLine($"{a} рублей");
                }
            }
        }


        //3. Написать программу, которая проверяет, является ли трехзначное число палиндромом(читается одинаково слева направо и справа налево).
        static void M2()
        {
            int a;
            Console.WriteLine("Введите трехзначное число");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            if (100 > a || a > 999)
            {
                Console.WriteLine("Число не является трехзначным");
            }
            else
            {
                int ff = a / 100;
                int gg = a % 10;
                //Console.WriteLine($"{ff} {gg}");
                if (ff == gg)
                {
                    Console.WriteLine("Чмсло является палиндромом");
                }
                else
                {
                    Console.WriteLine("Чмсло не является палиндромом");
                }
            }
        }


        //For5.Дано вещественное число — цена 1 кг конфет.Вывести стоимость 0.1,0.2, …, 1 кг конфет.
        static void M5()
        {
            double a;
            Console.WriteLine("Введите цену за кг конфет");
            string tmp = Console.ReadLine();
            a = double.Parse(tmp);
            for (double i = 0.1; i <= 1; i = i + 0.1)
            {
                Console.WriteLine("Цена за " + i + " кг кофет: " + i * a);
            }
        }


        //For6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2,1.4, …, 2 кг конфет.
        static void M6()
        {
            double a;
            Console.WriteLine("Введите цену за кг конфет");
            string tmp = Console.ReadLine();
            a = double.Parse(tmp);
            for (double i = 1.2; i <= 2; i = i + 0.2)
            {
                Console.WriteLine("Цена за " + i + " кг конфет: " + i * a);
            }
        }


        //For7. Даны два целых числа A и B (A<B). Найти сумму всех целых чисел от A до B включительно.
        static void M7()
        {
            int a;
            int b;
            int c = 0;
            Console.WriteLine("Введите  целое число A");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            Console.WriteLine("Введите целое число B");
            string tmk = Console.ReadLine();
            b = int.Parse(tmk);
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    c += i;
                }
                Console.WriteLine($"Сумма всех целых чисел от {a} до {b} включительно: {c}");
            }
            else
            {
                Console.WriteLine("Число A должно быть меньше числа B");
            }
        }


        //5. Вывести числа от 1 до 50, кратные 3. т.е. в цикле for перебираете все числа от 1 до 50,
        //и там же в цикле проверяете делится ли оно на 3 - для этого можно сравнить остаток от деления на 3 с нулем
        static void M8()
        {
            int a;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Числа от 1 до 50 кратные 3: {i} ");
                }
            }
        }


        //6. с использованием цикла for вычислить факториал введенного числа.Факториал - это произведение всех целых чисел от 1 до введенного числа, 
        //    т.е.если ввели 6, то результатом будет 1 * 2 * 3 * 4 * 5 * 6

        static void M9()
        {
            ulong a;
            ulong c = 1;
            Console.WriteLine("Введите  целое число: ");
            string tmp = Console.ReadLine();
            a = ulong.Parse(tmp);
            for (ulong i = 1; i <= a; i++)
            {
                c *= i;
            }
            Console.WriteLine($"Произведение всех целых чисел от {a} до  включительно: {c}");
        }

    
















        static void Main(string[] args)
        {
            M9();
        }
    }
}
