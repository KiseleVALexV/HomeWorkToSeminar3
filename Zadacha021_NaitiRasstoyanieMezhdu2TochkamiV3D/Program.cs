// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double GetDistance(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
double dist = Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2) + Math.Pow(coordZ2 - coordZ1, 2));
return dist;
}

Console.WriteLine("Введите координату X точки 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {dist}");
