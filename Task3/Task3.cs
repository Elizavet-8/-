using System;

namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
f*/
        internal static double F(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            else if (x % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return 366;
            }
            else
            {
                return 365;
            }
        }

        /*
         * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
         * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
         * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
         * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
         * Вернуть ориентацию локатора после выполнения этих команд.
         */


        internal static void Rotate1(ref char orientation, int cmd1, int cmd2)
        {
            switch (orientation)
            {
                case 'С':
                    switch (cmd1 + cmd2)
                    {
                        case -1:
                        case 3:
                            orientation = 'В';
                            break;
                        case 1:
                            orientation = 'З';
                            break;
                        case -2:
                        case 2:
                            orientation = 'Ю';
                            break;
                    }

                    break;
                case 'В':
                    switch (cmd1 + cmd2)
                    {
                        case -1:
                        case 3:
                            orientation = 'Ю';
                            break;
                        case 1:
                            orientation = 'С';
                            break;
                        case -2:
                        case 2:
                            orientation = 'З';
                            break;
                    }

                    break;
                case 'Ю':
                    switch (cmd1 + cmd2)
                    {
                        case -1:
                        case 3:
                            orientation = 'З';
                            break;
                        case 1:
                            orientation = 'В';
                            break;
                        case -2:
                        case 2:
                            orientation = 'С';
                            break;
                    }

                    break;
                case 'З':
                    switch (cmd1 + cmd2)
                    {
                        case -1:
                        case 3:
                            orientation = 'С';
                            break;
                        case 1:
                            orientation = 'Ю';
                            break;
                        case -2:
                        case 2:
                            orientation = 'В';
                            break;
                    }

                    break;
            }
        }


        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            throw new NotImplementedException();
        }


/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            string old = "";
            int d = age / 10, e = age % 10;

            //проверяем разряд десятков
            if (d == 2)
            {
                old = "двадцать";
            }
            else
            {
                if (d == 3)
                {
                    old = "тридцать";
                }
                else
                {
                    if (d == 4)
                    {
                        old = "сорок";
                    }
                    else
                    {
                        if (d == 5)
                        {
                            old = "пятьдесят";
                        }
                        else
                        {
                            if (d == 6)
                            {
                                old = "шестьдесят";
                            }
                        }
                    }
                }
            }

            //проверяем разряд единиц
            if (e == 0)
            {
                old += " лет";
            }
            else
            {
                if (e == 1)
                {
                    old += " один год";
                }
                else
                {
                    if (e == 2)
                    {
                        old += " два года";
                    }
                    else
                    {
                        if (e == 3)
                        {
                            old += " три года";
                        }
                        else
                        {
                            if (e == 4)
                            {
                                old += " четыре года";
                            }
                            else
                            {
                                if (e == 5)
                                {
                                    old += " пять лет";
                                }
                                else
                                {
                                    if (e == 6)
                                    {
                                        old += " шесть лет";
                                    }
                                    else
                                    {
                                        if (e == 7)
                                        {
                                            old += " семь лет";
                                        }
                                        else
                                        {
                                            if (e == 8)
                                            {
                                                old += " восемь лет";
                                            }
                                            else
                                            {
                                                old += " девять лет";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return old;
        }

        public static void Main(
            string[] args,
            double x,
            int year,
            char orientation, int cmd1, int cmd2,
            int age
        )
        {
            F(x);
            NumberOfDays(year);
            NumberOfDays(year);
            Rotate1(ref orientation, cmd1, cmd2);
            AgeDescription(age);
        }
    }
}