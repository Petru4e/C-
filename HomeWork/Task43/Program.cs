//  Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//    значения b1, k1, b2 и k2 задаются пользователем.

//k1*x+b1=k2*x+b2
//k1*x-k2*x=b2-b1
//x(k1-k2)=b2-b1
//x=(b2-b1)/(k1-k2)
//y=k1*x+b1

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter the coefficients");

Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

ValidatyAndPrint(b1, k1, b2, k2);

void ValidatyAndPrint(int valueB1, int valueK1, int valueB2, int valueK2)
{
    if (valueB1 == valueB2 && valueK1 == valueK2) Console.WriteLine("This is one straight line.");
    else if (valueK1 == valueK2) Console.WriteLine("Straight parallel.");
    else
    {
        double [] arrayPoint = PointIntersect(valueB1, valueK1, valueB2, valueK2);
        Console.WriteLine($"The lines intersect at a point: ({arrayPoint[0]};{arrayPoint[1]}).");
    }
}

double[] PointIntersect(int valueB1, int valueK1, int valueB2, int valueK2)
{
    double[] result = new double[2];
    result[0] = (double)(valueB2 - valueB1) / (valueK1 - valueK2);
    result[1] = valueK1 * result[0] + valueB1;
    return result;
}


