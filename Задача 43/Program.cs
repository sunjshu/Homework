//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
float b2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
float k2 = float.Parse(Console.ReadLine());

PrintInterSection(b1, b2, k1, k2);

void PrintInterSection(float b11, float b22, float k11, float k22)
{
    float x = (b22 - b11) / (k11 - k22);
    Console.WriteLine($"Точка пересечения: ({x};{k11 * x + b11})");
}

