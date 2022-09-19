// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите любое количество чисел разделенных запятой: ");
string numbers = Console.ReadLine();
string[] numbersSplit = numbers.Split(',');

Console.WriteLine(CountPositiveNumbers(numbersSplit));

int CountPositiveNumbers(string[] numSplit)
{
    int count = 0;
    for (int i = 0; i < numSplit.Length; i++)
    {
        if (int.Parse(numSplit[i]) > 0)
            count++;
    }
    return count;
}
