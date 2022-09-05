// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int CountNum(int num)
{
    int count = num;
    if (num < 1)
    {
        Console.WriteLine("Недопустимое число");
        return count;
    }
    if (num == 1)
    {
        Console.Write($"{count}.");
        return count;
    }
    Console.Write($"{count}, ");
    CountNum(num - 1);
    return count;
}

CountNum(number);