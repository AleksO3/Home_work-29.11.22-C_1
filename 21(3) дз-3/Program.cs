// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точки A, значения x y z");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B, значения x y z");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int Zb = Convert.ToInt32(Console.ReadLine());

if (Xa == Xb && Ya == Yb && Za == Zb)
{
    Console.WriteLine("Расстояние = 0; введите разные значения координат");
}
else
{
    double Res = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
    Console.WriteLine($"Длина отрезка AB равна {Res:f2}");
}