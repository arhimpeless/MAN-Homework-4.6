namespace Задание_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            while (true)
            {
                Console.WriteLine("Введите два целых одинаковых числа. ");
                Console.Write("Введите M: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Введите N: ");
                n = int.Parse(Console.ReadLine());
                int[,] array1 = new int[m, n]; //матрица М на N

                Random rnd = new Random();
                for (int x = 0; x < m; x++)     //перебор по х
                {
                    for (int y = 0; y < n; y++)  //перебор по y
                    {
                        array1[x, y] = rnd.Next(1, 21);
                        Console.Write(array1[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < m; i++)  // нахождение максимального значения в строке
                {
                    int max = array1[i, 0];
                    for (int j = 0; j < n; j++)
                    {
                        if (array1[i, j] > max)
                        {
                            max = array1[i, j];
                        }
                    }
                    Console.WriteLine("max значение в строке " + (i + 1) + " : {0}", max);
                }
                GetMinValueColumns(array1);
                Console.WriteLine();
            }
        }

        private static void GetMinValueColumns(int[,] array1)
        {
            int min = 0;
            int m = array1.GetLength(0);
            int n = array1.GetLength(1);
            for (int j = 0; j < n; j++)  // нахождение минимального значения в столбце
            {
                min = array1[0, j];
                for (int i = 0; i < m; i++)
                {
                    if (array1[i, j] < min)
                    {
                        min = array1[i, j];
                    }
                }
                Console.WriteLine("min значение в столбце " + (j + 1) + " : {0}", min);
            }
        }
    }
}