namespace Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Матрицы

            int N = 5;
            int M = 7;
            Random random = new Random();
            int[,] matrix = new int[N, M]; //5 строк, 7 столбцов



            //Сгенерировать матрицу NxM из случайных чисел
            //в диапазоне от 10..99
            //И вывести ее в виде таблицы


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int rand = random.Next(10, 100);
                    matrix[i, j] = rand;
                }

            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} |");
                }
                Console.WriteLine();
            }

            //Посчитать и вывести среднее в матрице

            double average = 0;
            double count = 0;
            double sum = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    count++;
                    sum += matrix[j, i];
                }
                average = sum / count;
                Console.WriteLine();
                Console.WriteLine(sum);
                Console.WriteLine($"Среднее {i} столбца - {average}");
                count = 0;
                sum = 0;

            }

            //Максимум каждого столбца
            int max = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[j, i] > max)
                    {
                        max = matrix[j, i];

                    }

                }
                Console.WriteLine($"Максимум {i} столбца - матрицы {max}");
                max = 0;
            }

            //1. Поменять строку с номером P со строкой с номером Q. P и Q вводит пользователь

            Console.WriteLine("Введите строку которую меняем");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите строку на которую меняем");
            int q = int.Parse(Console.ReadLine());

            // for (int i = 0; i < N; i++)
            int matrix2 = 0;

            for (int j = 0; j < M; j++)
            {
                matrix2 = matrix[p, j];
                matrix[p, j] = matrix[q, j];
                matrix[q, j] = matrix2;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} |");
                }
                Console.WriteLine();
            }


            //2. Превратить все числа больше 50 в отрицательные и вывести матрицу.
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matrix[i, j] > 50)
                    {
                        matrix[i, j] = matrix[i, j] * -1;
                    }
                }
            }
            Console.WriteLine("Матрица после превращения умножения на  -1 чисел больше 50 :");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} |");
                }
                Console.WriteLine();
            }
            //3. Выбрать из матрицы только числа, у которых строго два делителя (помимо 1 и себя самого) и вывести их
            Console.WriteLine();
            Console.WriteLine("Числа с двумя делителями:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int numbers = matrix[i, j];
                    int dividers = 0;
                    for (int k = 2; k < numbers; k++)
                    {
                        if (numbers % k == 0)
                        {
                            dividers++;
                        }
                    }
                    if (dividers == 2)
                    {
                        Console.Write($"{numbers} ");
                    }
                }

                //Почитать: сложение матриц, умножение матрицы на число, умножение матриц друг на друга, расчет определителя матрицы.
            }
            Console.WriteLine();
            int NUM = 5;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = matrix[i, j] * 5;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] matrix3 = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int rand = random.Next(10, 100);
                    matrix3[i, j] = rand;
                    Console.Write($"{matrix3[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] += matrix3[i, j];
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{matrix[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int O = 5;
            int P = 7;

            int[,] matrix4 = new int[O, P]; //5 строк, 7 столбцов
            Console.WriteLine("Матрица4");
            for (int i = 0; i < O; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    int rand = random.Next(1, 10);
                    matrix4[i, j] = rand;
                    Console.Write($"{matrix4[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int Q = 7;
            int R = 6;

            int[,] matrix5 = new int[Q, R]; //5 строк, 7 столбцов
            Console.WriteLine("Матрица5");
            for (int i = 0; i < Q; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    int rand = random.Next(1, 10);
                    matrix5[i, j] = rand;
                    Console.Write($"{matrix5[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Умножить матрицы matrix4 и matrix5
            int S = O;
            int T = R;
            //int count2 = 0;
            int[,] matrixResult = new int[Q, R]; //5 строк, 7 столбцов

            //for (int i = 0; i < P; i++)  //P = 5
            //{
            //    count2 += matrix4[0, i] * matrix5[i, 0];
            //}

            //count2 += matrix4[0, 0] * matrix5[0, 0];
            //count2 += matrix4[0, 1] * matrix5[1, 0];
            //count2 += matrix4[0, 2] * matrix5[2, 0];
            //count2 += matrix4[0, 3] * matrix5[3, 0];
            //count2 += matrix4[0, 4] * matrix5[4, 0];

            //matrixResult[0, 0] = count2;


            for (int i = 0; i < S; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    int count2 = 0;
                    for (int k = 0; k < P; k++) // Проходим по столбцам матрицы matrix4 и по строкам матрицы matrix5
                    {
                        count2 += matrix4[i, k] * matrix5[k, j]; // Умножаем  значения строк на значения столбцов и  добавляем результат к сумме
                    }
                    matrixResult[i, j] = count2; // Записываем полученную сумму в ячейку результирующей матрицы
                    Console.Write($"{matrixResult[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            //Дан текст. Разбить его на матрицу слов и вывести
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine()/*"Test text lol abc fghjtynf 6."*/;
            char[,] result; // = new char[??, ??];

            char ch = (char)0;
            int Ch = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            while (Ch <= text.Length - 1)
            {
                if (text[Ch] != ' ')
                {
                    count3++;
                }
                else
                {
                    if (count3 > count4)
                    {
                        count4 = count3;
                    }
                    count5++;
                    count3 = 0;
                }
                Ch++;
            }
            count5++;

            Console.WriteLine(count4);
            Console.WriteLine(count5);

            result = new char[count5, count4];
            Ch = 0;
            //for(int i = 0; i < count4; i++)
            //{
            //    for(int j = 0; j < count5; j++)
            //    {
            //        result[i,j] = 
            //    }
            //}
            int height = 0;
            int weight = 0;

            while (Ch <= text.Length - 1)
            {
                if (text[Ch] != ' ')
                {

                    result[height, weight] = text[Ch];
                    weight++;


                }

                else
                {
                    weight = 0;
                    height++;
                }
                Ch++;
            }
            for (int i = 0; i < count5; i++)
            {
                for (int j = 0; j < count4; j++)
                {

                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }


            //Test
            //text
            //lol
            //abc
            //6.

            //1. Дана матрица символов. Найти и вывести из нее все символы с количеством их в матрице.
            //a e a
            //e d e

            //a - 2
            //d - 1
            //e - 3

            char[,] ChMatrix = new char[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    char rand = (char)random.Next('a', 'z');
                    ChMatrix[i, j] = rand;
                }

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{ChMatrix[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //char ChMatrixChar = ' ';
            int count8 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    count8++;
                    bool variable = true;
                    int count9 = 0;
                    for (int h = 0; h < N; h++)
                    {
                        for (int f = 0; f < M; f++)
                        {
                            count9++;
                            if (count9 == count8)
                                break;
                            if (ChMatrix[h, f] == ChMatrix[i, j])
                            {
                                variable = false;
                            }
                        }
                    }

                    if (variable == false)
                        continue;


                    int count6 = 0;
                    char ChMatrixChar = ChMatrix[i, j];

                    for (int k = 0; k < N; k++)
                    {
                        for (int l = 0; l < M; l++)
                        {
                            if (ChMatrix[k, l] == ChMatrixChar)
                            {
                                count6++;


                            }
                        }
                    }
                    Console.WriteLine($"{ChMatrixChar} - {count6}");
                }
                Console.WriteLine();
            }



            //2. Дана матрица случайных чисел. Вывбрать из нее только числа, которые делятся на N (ее вводит пользователь) и сформировать из этих чисел
            //новую марицу максимально квадратного размера и вывести.
            //1 2 3 4  5  6
            //7 8 9 10 11 12
            //2 6 3 2  1  7

            //2

            //всего 9 чисел, которые делятся на 2, значит можно сделать матрицу 3х3. Создадим:
            //2 4  6
            //8 10 12
            //2 6  2
            int[,] newMatrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int rand = random.Next(1, 10);
                    newMatrix[i, j] = rand;
                }

            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{newMatrix[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Введите делитель на который будем делить значения в матрице");
            int Divider = Convert.ToInt32(Console.ReadLine());
            int div1 = 0;
            int div2 = 0;
            int count7 = 0;

            int minDiv1 = 0;
            int minDiv2 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (newMatrix[i, j] % Divider == 0)
                    {
                        count7++;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine(count7);
            int Result = count7;
            //count7 = Convert.ToInt32(Math.Sqrt(count7));
            //Console.WriteLine();
            //Console.WriteLine(count7);

            for (int i = 1; i <= count7; i++)
            {
                if (count7 % i == 0)
                {
                    div1 = count7 / i;
                    div2 = i;
                }
                if (Math.Abs(div1 - div2) < Result)
                {
                    Result = Math.Abs(div1 - div2);
                    minDiv1 = div1;
                    minDiv2 = div2;
                }

            }
            Console.WriteLine(minDiv1);
            Console.WriteLine(minDiv2);



            Console.WriteLine($"Матрица квадратного размера из чисел в предыдущей матрице которые делятся на {Divider}");
            int[,] newMatrix1 = new int[minDiv1, minDiv2];

            int k1 = 0, l1 = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    if (newMatrix[i, j] % Divider == 0)
                    {
                        newMatrix1[k1, l1] = newMatrix[i, j];
                        l1++;
                        if (l1 == minDiv2)
                        {
                            k1++;
                            l1 = 0;
                        }
                    }



                }

            }


            for (int i = 0; i < minDiv1; i++)
            {
                for (int j = 0; j < minDiv2; j++)
                {
                    Console.Write($"{newMatrix1[i, j]} |");
                }
                Console.WriteLine();
            }


            //1. Повернуть матрицу на бок.
            //2. Даны две матрицы со случайными числами от 10..99. Вывести отдельный массив, содержащий числа, которые встречаются в обеих матрицах (без повторов).
        }
    }
}