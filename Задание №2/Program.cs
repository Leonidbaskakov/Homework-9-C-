// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine($"Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n == m)
{
    Console.WriteLine("Недопустимый промежуток");
    return;
}

int CountNum(int num1, int num2)
{
    int count = num2;
    if (num2 > num1) count += CountNum(num1, num2 - 1);
    else
    if (num2 < num1) count += CountNum(num1, num2 + 1);
    return count;
}

int sumcount = CountNum(m, n);

Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} -> {sumcount}");
