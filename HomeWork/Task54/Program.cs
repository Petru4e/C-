// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array2d = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
FillArray(array2d);
Console.WriteLine("Original matrix");
PrintArray(array2d);
Console.WriteLine("Sort matrix");
MatrixSort(array2d);
PrintArray(array2d);

void MatrixSort(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = matrix.GetLength(1) - 1; column > 0; column--)
        {
            int minIndex = column;
            for (int j = 0; j < column; j++)
            {
                if (matrix[row, j] < matrix[row, minIndex]) minIndex = j;
            }

            if (minIndex != column)
            {
                (matrix[row, minIndex], matrix[row, column]) = (matrix[row, column], matrix[row, minIndex]);
            }

        }
    }
}

void FillArray(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

