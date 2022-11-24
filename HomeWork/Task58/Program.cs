// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstArray2d = new int[new Random().Next(1, 5), new Random().Next(3, 5)];
int[,] secondArray2d = new int[new Random().Next(3, 4), new Random().Next(1, 5)];
int maxValue = 10;
int minVaue = 1;

Console.WriteLine("First matrix");
FillArray(firstArray2d, maxValue, minVaue);
PrintArray(firstArray2d);

Console.WriteLine("Second matrix");
FillArray(secondArray2d, maxValue, minVaue);
PrintArray(secondArray2d);

if (firstArray2d.GetLength(1) != secondArray2d.GetLength(0))
{
    Console.WriteLine("These matrices cannot be multiplied");
}
else
{
    int[,] multyMatrix = MatrixMultiplication(firstArray2d, secondArray2d);
    Console.WriteLine("Mult Matrix");
    PrintArray(multyMatrix);
}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < secondMatrix.GetLength(1); n++)
            {
                multMatrix[i, n] = multMatrix[i, n] + (firstMatrix[i, j] * secondMatrix[j, n]);
            }
        }
    }
    return multMatrix;
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

