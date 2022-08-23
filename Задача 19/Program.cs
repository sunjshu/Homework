/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и
проверяет, является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, 
исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99999 || num < 10000)
{
    Console.Write("Введено некорректное число");
}
else
{
    Console.WriteLine(IsPalyndrome(num) ? "да" : "нет");
}

bool IsPalyndrome(int num)
{
    int num1 = num / 10000;
    int num5 = num % 10;
    if (num1 != num5)
    {
        return false;
    }
    int num2 = (num % 10000) / 1000;
    int num4 = (num % 100) / 10;
    if (num2 != num4)
    {
        return false;

    }

    return true;

}