using System;
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
            int b;
            Console.WriteLine("Введите количество рублей");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            if (a < 0)
            {
                Console.WriteLine("Введите положмтельное число");
            }
            else
            {
                b = a % 10;
                if (b == 1)
                {
                    Console.WriteLine($"{a} рубль");
                }
                else if (b == 0 || b == 5 || b == 6 || b == 7 || b == 8 || b == 9)
                {
                    Console.WriteLine($"{a} рублей");
                }
                else {
                    Console.WriteLine($"{a} рубля");
                }
            }
        }


        //3. Написать программу, которая проверяет, является ли трехзначное число палиндромом(читается одинаково слева направо и справа налево).
        static void M2()
        {
            int a;
            int b;
            Console.WriteLine("Введите трехзначное число");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            if (100 > a || a > 999)
            {
                Console.WriteLine("Число не является трехзначным");
            }
            else
            {
                int ff = (a / 100) % 10;
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
            int a;
            int c = 1;
            Console.WriteLine("Введите  целое число A");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            for (int i = 1; i <= a; i++)
            {
                c *= i;
            }
            Console.WriteLine($"Сумма всех целых чисел от {a} до  включительно: {c}");
        }

    





















        static void If10()
        {
            int a;
            int b;
            Console.WriteLine("введите значение а ");
            string q = Console.ReadLine();
            a = int.Parse(q);
            Console.WriteLine("введите значение в ");
            string w = Console.ReadLine();
            b = int.Parse(w);
            if (a != b) {
                a = a + b;
                b = a;
            } else {
                a = 0;
                b = 0;
            }
            Console.WriteLine("a = " + a + " b = " + b);
        }
        static void Begin5()
        {

            int a;

            string tmp = Console.ReadLine();
            a = int.Parse(tmp);
            if (a > 0) {
                a = a + 1;
                Console.WriteLine($"Число a {a} положительное");
            } else if (a == 0) {
                Console.WriteLine("a равно нулю");
            } else { //все остальные случаи
                Console.WriteLine("a отрицательное");
            }
        }

        static void If11()
        {
            Console.WriteLine("If11");
            int a;
            int b;
            int c;
            Console.WriteLine("введите значение а ");
            string q = Console.ReadLine();
            a = int.Parse(q);
            Console.WriteLine("введите значение в ");
            q = Console.ReadLine();
            b = int.Parse(q);
            Console.WriteLine("введите значение c ");
            q = Console.ReadLine();
            c = int.Parse(q);
            if (a < b && a < c) {
                Console.WriteLine("a наименьшее");
            } else if (b < c && b < a) {
                Console.WriteLine("b наименьшее");
            } else if (c < a && c < b) {
                Console.WriteLine("c наименьшее");
            } else {
                Console.WriteLine("числа равны");
            }
        }
        static void If14()
        {
            double a;   
            double b;
            double c;
            Console.WriteLine("введите значение а ");
            string q = Console.ReadLine();
            a = int.Parse(q);
            Console.WriteLine("введите значение в ");
            q = Console.ReadLine();
            b = int.Parse(q);
            Console.WriteLine("введите значение c ");
            q = Console.ReadLine();
            c = int.Parse(q);
            if (a > b && a > c) 
            {
                if (b > c ) {
                    Console.WriteLine($"Наименьшее число: {c}");
                }
                else {
                    Console.WriteLine($"Наименьшее число: {b}");
                }
                Console.WriteLine($"Наибольшее число: {a}");
            }
            else if (b > c && b > a) {
                if (a > c) {
                    Console.WriteLine($"Наименьшее число: {c}");
                } else {
                    Console.WriteLine($"Наименьшее число: {a}");
                }
                Console.WriteLine($"Наибольшее число: {b}");
            }
            else if (c > a && c > b) 
            {
                if (a > b) {
                    Console.WriteLine($"Наименьшее число: {b}");
                } else {
                    Console.WriteLine($"Наименьшее число: {a}");
                }
                Console.WriteLine($"Наибольшее число: {c}");
            }
        }

        static void For1()
        {
            Console.WriteLine("for1");
            int n;
            int k;
            Console.WriteLine("введите значение N ");
            string q = Console.ReadLine();
            n = int.Parse(q);
            Console.WriteLine("введите значение K ");
            q = Console.ReadLine();
            k = int.Parse(q);
            //N = 3
            //K = 5
            //5 5 5
            Console.WriteLine("------------------------");
            for( int i = 0; i < n ; i = i + 1) {
                Console.WriteLine(k);
            }

        }
        static void For4()
        {
            int a;
            Console.WriteLine("введите цену за кг ");
            string b = Console.ReadLine();
            a = int.Parse(b);

            for (int i = 1; i <= 10; i = i + 1) 
            {
                Console.WriteLine("Цена за " + i + " кг " + i * a);
            }
        }


            static void For2()
        {
            Console.WriteLine("for2");
            int a;
            int b;
            Console.WriteLine("введите значение а ");
            string q = Console.ReadLine();
            a = int.Parse(q);
            Console.WriteLine("введите значение в ");
            q = Console.ReadLine();
            b = int.Parse(q);
            //for( задание начальных значений ; условие продолжения цикла   ;  действие, выполняемое после цикла  )
            //a = 5;
            //b = 10;
            //должно вывести: 5, 6, 7, .. 10
            int cnt =0;
            for( int i = a; i <= b; i = i + 1) {
                Console.WriteLine(i);
                cnt++;
            }
            Console.WriteLine($"cnt = {cnt}");
        }

        static void Main(string[] args)
        {
            M9();
        }
    }
}
