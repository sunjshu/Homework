/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите первую координату точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату точки А: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату точки B: ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
Console.Write($"Расстояние между точками в 3D пространстве:{distance:f2}");
