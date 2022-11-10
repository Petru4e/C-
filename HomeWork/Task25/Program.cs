// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second (natural) number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 < 1)
{
    Console.WriteLine("Your number is not a non-natural number. Do you want to continue with your number?y/n");
    char answer = Convert.ToChar(Console.ReadLine());
    if (answer == 'n')
    {
        do
        {
            Console.WriteLine("Enter the second (natural) number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        } while (num2 < 1);
    }
}
Console.WriteLine((num1 == 0 && num2 == 0) ? "The expression doesn't make sense" : $"{num1} to the extent of {num2} equally {NumberPow(num1, num2)}");//исключаем вариант возведения 0 в степень 0

double NumberPow(double number1, int number2)
{
    double result = number1;
    if (number2 == 0) return 1;//любое число (кроме 0) в степени 0 равно 1
    for (int i = 1; i < Math.Abs(number2); i++)// берем по модуль для случая отрицательной степени
    {
        result = result * number1;
    }
    return (number2 > 0)?result:1 / result;
}