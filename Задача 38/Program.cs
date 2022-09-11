// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] array = new float[8];
Random rand = new Random();
float min = 999;
float max = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 999);
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];

}
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(max - min);