// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xa-xb),2)+Math.Pow((ya-yb),2)+Math.Pow((za-zb),2));
}



System.Console.WriteLine("Enter the coordinates of the first point: ");
System.Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the coordinates of the second point: ");
System.Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Distance(x1,y1,z1,x2,y2,z2),2,MidpointRounding.AwayFromZero));


