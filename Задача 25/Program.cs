// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());


int Degree(int a, int b)
{
    int count = 1;
    int d = a;

    while (count < b)
    {

        count++;
        d = d * a;


    }
    return d;
}
Console.WriteLine(Degree(A, B));