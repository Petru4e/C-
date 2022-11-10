// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number: ");
int number =Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitInNumber(number));

int SumDigitInNumber(int num)
{
    int result = 0;
    num=Math.Abs(num);
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}