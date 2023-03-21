// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
System.Console.WriteLine("Задайте начальный массив.");
int m = Promt("Введите кол-во строк m: ");
int n = Promt("Введите кол-во столбцов n: ");

int[,] generateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void arrayOutput(int[,] mas)
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
void arithmeticMean(int[,] mas)
{
    double sum = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += mas[i, j];
        }
        sum /= m;
        System.Console.Write($"{Math.Round(sum, 1)};");
        sum = 0;
    }
}
int[,] array = generateArray(m, n);
arrayOutput(array);
arithmeticMean(array);