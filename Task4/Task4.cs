namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i = 1; i <= height; i++)
            {
                
                if (i == 1 || i == height)
                {
                    for (int j = 1; j <= width; j++)
                        Console.Write(frameChar);
                }
                else
                {
                    Console.Write(frameChar);
                    for(int l=1;l<width-1;l++)
                        Console.Write(' ');
                    Console.Write(frameChar);
                }
                Console.WriteLine();
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 1;
            while (i <= height) 
            {
                
                if (i == 1 || i == height)
                {
                    int j = 1;
                    while (j <= width)
                    {
                        Console.Write(frameChar);
                        j++;
                    }
                }
                else
                {
                    Console.Write(frameChar);
                    int l = 1;
                    while (l < width - 1)
                    {
                        l++;
                        Console.Write(' ');
                    }

                    Console.Write(frameChar);
                }
                Console.WriteLine();
                i++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return b;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            throw new NotImplementedException();
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            throw new NotImplementedException(
                "Вызовите здесь все перечисленные в классе функции, как это сделано в предыдущих заданиях");
        }
    }
}