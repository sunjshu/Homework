// Задача 29: Напишите программу, 
// которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран

Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

RandArray(num);

void RandArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 450);
    }
    Console.Write($"[{String.Join(",", arr)}]");
}
