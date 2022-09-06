// Задача 27: Напишите функцию и запустите ее, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;

}
Console.Write(SumNum(num));