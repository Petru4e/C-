// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

(int min, int max) MinMaxValue(int numM, int numN)
{
    return (numM, numN) = (Math.Min(numM, numN), Math.Max(numM, numN));
}
int SumNumbersMN(int numM, int numN)
{
    if (numM <= numN) return numN + SumNumbersMN(numM, numN - 1);
    return 0;
}


Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
(m, n) = MinMaxValue(m, n);
Console.WriteLine(SumNumbersMN(m, n));
