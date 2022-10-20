// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

System.Console.Write("Enter x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
int quarter = Quarter(x, y);
string result = quarter>0?$"Quarter: {quarter}":"Incorrect coordinates";
System.Console.WriteLine(result);