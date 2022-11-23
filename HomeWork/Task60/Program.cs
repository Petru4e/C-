// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Array3d = new int[new Random().Next(1, 5), new Random().Next(1, 5),new Random().Next(1, 5)];

Console.WriteLine($"Row {Array3d.GetLength(0)}");//для наглядности
Console.WriteLine($"Column {Array3d.GetLength(1)}");
Console.WriteLine($"Depth {Array3d.GetLength(2)}");

FillArray(Array3d);
PrintArray(Array3d);

void FillArray(int[,,] tridimensional)
{
    Random rnd = new Random();
    int temp=10;
    for (int i = 0; i < tridimensional.GetLength(0); i++)
    {
        for (int j = 0; j < tridimensional.GetLength(1); j++)
        {
            for (int k = 0; k < tridimensional.GetLength(2); k++)
            {
                tridimensional[i,j,k]=temp;
                temp+=rnd.Next(1,5);
            }
        }
    }
}

void PrintArray(int[,,] tridimensional)
{

    for (int i = 0; i < tridimensional.GetLength(0); i++)
    {
        for (int j = 0; j < tridimensional.GetLength(1); j++)
        {
            for (int k = 0; k < tridimensional.GetLength(2); k++)
            {
                Console.Write($"{tridimensional[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}