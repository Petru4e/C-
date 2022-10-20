// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

System.Console.Write("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Range(int q)
{
    string answer;
    switch (q)
    {
        case 1: answer=$" x > 0 и y > 0"; break;
        case 2: answer= $" x < 0 и y > 0"; break;
        case 3: answer= $" x < 0 и y < 0"; break;
        case 4: answer=$" x > 0 и y < 0"; break;
        default: answer=$"Не корректные данные"; break;
    }
    return answer;
}
System.Console.WriteLine(Range(quarter));
