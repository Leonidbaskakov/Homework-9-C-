// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine($"Введите целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 <= 0 || number2 <= 0)
{
    Console.WriteLine("Оба числа должны быть больше 0");
    return;
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    return 0;
}

int acknum = Ackerman(number1, number2);

Console.WriteLine($"Число Аккермана двух чисел ({number1} и {number2}) ->{acknum} ");