// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
System.Console.WriteLine("Задайте начальный массив.");
int m = Promt("Введите кол-во строк m: ");
int n = Promt("Введите кол-во столбцов n: ");

double[,] generateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
    return array;
}

void arrayOutput(double[,] mas)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }

}

double[,] array = generateArray(m, n);
arrayOutput(array);