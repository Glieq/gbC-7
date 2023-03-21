// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет


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
            array[i, j] = random.Next(1, 101);
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

int[,] array = generateArray(m, n);
arrayOutput(array);

void findElement(int row, int column)
{
    int rememberNum = 0;
    Boolean isThereNumber = false;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == row && j == column)
            {
                rememberNum = array[i, j];
                isThereNumber = true;
                System.Console.WriteLine($"Число на позиции [{row},{column}]: {rememberNum}");
                return;
            }
        }
    }
    if (!isThereNumber)
    {
        System.Console.WriteLine($"Такого числа в массиве нет");
        return;
    }

}

int needM = Promt("Введите строку искомого элемента: ");
int needN = Promt("Введите столбец искомого элемента: ");

findElement(needM, needN);