// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2d = new int[new Random().Next(1, 15), new Random().Next(1, 15)];
FillArray(array2d);
PrintArray(array2d);

double[] averageValue = new double[array2d.GetLength(1)];
AverageValue(array2d,averageValue);
PrintAverageValue(averageValue);

void PrintAverageValue(double[] array)
{
    Console.WriteLine();
    foreach (var item in array)
    {
        Console.Write($" {item,3} ");
    }
}

void AverageValue(int[,] matrix, double[] array)
{
    int rowCount = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum=0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        array[i]=Math.Round((double)sum/rowCount,1);
    }
}

void FillArray(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,10);
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