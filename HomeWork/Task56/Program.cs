// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 


int[,] array2d = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
int maxValue = 10;
int minVaue = 1;

FillArray(array2d, maxValue, minVaue);
PrintArray(array2d);
Console.WriteLine($"Minimum sum of elements in line number {MinSumRow(array2d) + 1}");//плюс один просто для красоты вывода

void FillArray(int[,] matrix, int max, int min)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) Console.Write($"{matrix[i, matrix.GetLength(1) - 1],3} ");
            else Console.Write($"{matrix[i, j],3} |");
        }
        Console.WriteLine($"|");
    }
}

int MinSumRow(int[,] matrix)
{
    int minSum = matrix.GetLength(1) * maxValue + 1;//увеличиваем значение на один чтобы точно был вариант найти меньшее значение
    int minRow = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Row {i + 1} sum={sum}");//вывод чтобы удобнее было проверить
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}
