// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Enter m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n:  ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m, n];
FillArray(array2d);
PrintArray(array2d);

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
