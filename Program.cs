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

            // matrix[0, 0] = 10;
            // matrix[4, 6] = -1;
            /* for(int i = 0; i < N; i++)
                  for(int j = 0; j < M; j++)
                      matrix[i, j] = 5;

             for(int i = 0; i < N; i++)
                  Console.Write(matrix[i, 4] + " ");*/

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
                    if (matrix[j, i] > max )
                    {
                        max = matrix[j, i];

                    }

                }
                Console.WriteLine($"Максимум {i} столбца - матрицы {max}");
                max = 0;
            }

            //1. Поменять строку с номером P со строкой с номером Q. P и Q вводит пользователь
            //2. Превратить все числа больше 50 в отрицательные и вывести матрицу.
            //3. Выбрать из матрицы только числа, у которых строго два делителя (помимо 1 и себя самого) и вывести их

            //Почитать: сложение матриц, умножение матрицы на число, умножение матриц друг на друга, расчет определителя матрицы.
        }
    }
}