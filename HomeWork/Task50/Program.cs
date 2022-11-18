// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает
//   значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.WriteLine("Enter m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2d = new double[new Random().Next(1, 9), new Random().Next(1, 9)];
Console.WriteLine($"Array size : [{array2d.GetLength(0)}, {array2d.GetLength(1)}]");
Console.WriteLine();

FillArray(array2d);
PrintArray(array2d);
Console.WriteLine();
SearchElem(array2d.GetLength(0), array2d.GetLength(1));

void SearchElem(int row, int column)
{
    if (m < row && n < column) Console.WriteLine($"Element [{m}, {n}] value {array2d[m,n]}.");
    else Console.WriteLine("There is no such element in the array");
}

void FillArray(double[,] matrix)
{
    double minRange = -100;
    double maxRange = 100;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (maxRange - minRange) + minRange), 1);
        }

    }
}

void PrintArray(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) Console.Write($"{matrix[i, matrix.GetLength(1) - 1],5} ");
            else Console.Write($"{matrix[i, j],5} |");
        }
        Console.WriteLine($"|");
    }

}
