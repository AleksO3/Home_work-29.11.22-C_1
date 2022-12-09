// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.WriteLine("Введите координаты точки A, значения x и y");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B, значения x и y");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int Yb = Convert.ToInt32(Console.ReadLine());

if (Xa == Xb && Ya == Yb)
{
    Console.WriteLine("Расстояние = 0; введите разные значения координат");
}
else
{
    double Res = Math.Sqrt(Math.Pow(Xb - Xa,2) + Math.Pow(Yb - Ya,2));
    Console.WriteLine($"Длина отрезка AB равна {Res}");
}