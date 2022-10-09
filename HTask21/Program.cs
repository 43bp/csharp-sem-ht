// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки");
Console.WriteLine("xa = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
Console.WriteLine("ya = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
Console.WriteLine("za = ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
Console.WriteLine("xb = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
Console.WriteLine("yb = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
Console.WriteLine("zb = ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow ((xb - xa), 2) + Math.Pow ((yb - ya), 2) + Math.Pow ((zb - za), 2));
double distanceD = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между двумя точками в пространстве: {distanceD}");